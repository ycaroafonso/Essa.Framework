using System;
using System.Globalization;
using System.Linq;
using MixERP.Net.VCards.Models;
using MixERP.Net.VCards.Serializer;

namespace MixERP.Net.VCards.Processors
{
    public static class TimeZoneInfoProcessor
    {
        public static string ToVCardValue(TimeZoneInfo timeZone)
        {
            if (timeZone == null)
            {
                return string.Empty;
            }

            var offset = timeZone.BaseUtcOffset;
            var iso8601 = offset.ToString("hh\\:mm");

            if (offset.TotalMilliseconds < 0)
            {
                iso8601 = "-" + iso8601;
            }

            return iso8601;
        }

        public static string Serialize(VCard vcard)
        {
            var timeZone = ToVCardValue(vcard.TimeZone);
            if (string.IsNullOrWhiteSpace(timeZone))
            {
                return string.Empty;
            }

            return DefaultSerializer.GetVCardString("TZ", timeZone, false, vcard.Version);
        }

        //Todo: verify the correctness of this function
        //Please note that the string representation of time zone is an ISO 8601 time span.
        public static TimeZoneInfo FromVCardValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            var timeSpan = TimeSpan.Zero;

            if (value.Contains(":"))
            {
                timeSpan = TimeSpan.Parse(value);
            }
            else
            {
                if (value.StartsWith("-"))
                {
                    value = value.Substring(1);

                    if (value.Length == 4)
                    {
                        timeSpan = TimeSpan.ParseExact(value, "hhmm", CultureInfo.InvariantCulture).Negate();
                    }

                    if (value.Length == 6)
                    {
                        timeSpan = TimeSpan.ParseExact(value, "hhmmss", CultureInfo.InvariantCulture).Negate();
                    }
                }
                else
                {
                    timeSpan = TimeSpan.ParseExact(value, "hhmm", CultureInfo.InvariantCulture);
                }
            }

            if (timeSpan == TimeSpan.Zero)
            {
                return null;
            }

            return TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(x => x.BaseUtcOffset == timeSpan);
        }

        public static void Parse(Token token, ref VCard vcard)
        {
            var value = token.Values[0];
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var timezone = FromVCardValue(value);
            if (timezone == null)
            {
                return;
            }

            vcard.TimeZone = timezone;
        }
    }
}