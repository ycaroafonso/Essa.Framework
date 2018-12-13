using System;
using System.Collections.Generic;
using System.Linq;

namespace MixERP.Net.VCards.Extensions
{
    public static class Sanitizer
    {
        private static readonly Dictionary<string, string> EspaceTokens = new Dictionary<string, string>
        {
            {Environment.NewLine, @"\n"},
            {@"\", @"\\"},
            {",", @"\,"},
            {";", @"\;"},
            {":", @"\:"}
        };

        public static string Escape(this string value)
        {
            return string.IsNullOrWhiteSpace(value) ? string.Empty : EspaceTokens.Aggregate(value, (current, token) => current.Replace(token.Key, token.Value));
        }

        public static string UnEscape(this string value)
        {
            return EspaceTokens.Aggregate(value, (current, token) => current.Replace(token.Value, token.Key));
        }
    }
}