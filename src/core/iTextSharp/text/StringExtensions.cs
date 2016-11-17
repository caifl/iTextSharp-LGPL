using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {

        public static string ToLower(this string s, CultureInfo info)
        {
            return s.ToLowerInvariant();
        }

        public static string ToUpper(this string s, CultureInfo info)
        {
            return s.ToUpperInvariant();
        }
    }
}
