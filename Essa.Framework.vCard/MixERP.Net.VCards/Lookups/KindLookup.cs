﻿using System;
using System.Collections.Generic;
using System.Linq;
using MixERP.Net.VCards.Types;

namespace MixERP.Net.VCards.Lookups
{
    public static class KindLookup
    {
        private static readonly Dictionary<Kind, string> Lookup = new Dictionary<Kind, string>
        {
            {Kind.Individual, "individual"},
            {Kind.Group, "group"},
            {Kind.Organization, "org"},
            {Kind.Location, "location"}
        };

        public static string ToVCardString(this Kind type)
        {
            return Lookup[type];
        }

        public static Kind Parse(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                return Kind.Individual;
            }

            return Lookup.FirstOrDefault(x => string.Equals(x.Value, type, StringComparison.OrdinalIgnoreCase)).Key;
        }
    }
}