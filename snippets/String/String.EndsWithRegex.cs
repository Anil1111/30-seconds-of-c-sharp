﻿using System.Text.RegularExpressions;

namespace conplement.snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Check if a string ends with a given substring using a regex
        /// </summary>
        public static bool EndsWithRegex(this string input, Regex regex)
        {
            return regex.IsMatch(input);
        }
    }
}
