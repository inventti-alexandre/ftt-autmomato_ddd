using System;
using System.Collections.Generic;
using System.Linq;

namespace Automato.Validation
{
    public static class AutomataAssertion
    {
        public static void IsNotNull(this string value, string message)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(FormatErrorMessage(value, message));
        }

        public static void IsValidState(this string q0, IEnumerable<string> states, string message)
        {
            if (!states.Contains(q0))
                throw new ArgumentException(message);
        }

        public static void IsValidSymbol(this string symbol, IEnumerable<string> alphabet, string message)
        {
            IsValidState(symbol, alphabet, message);
        }

        public static void MinLength(this IEnumerable<string> value, int minLength, string message)
        {
            if (value.Count() < minLength)
                throw new ArgumentOutOfRangeException(message);
        }

        public static void LengthIsEqual(this IEnumerable<string> value, int length, string message)
        {
            if (value.Count() != length)
                throw new ArgumentOutOfRangeException(message);
        }

        public static string Format(this string value)
        {
            return value.Trim()
                        .Replace("(", "")
                        .Replace(")", "");
        }

        private static string FormatErrorMessage(Object value, string message)
        {
            return String.Format("Error: {0}, - Value: {1}", message, value);
        }
    }
}