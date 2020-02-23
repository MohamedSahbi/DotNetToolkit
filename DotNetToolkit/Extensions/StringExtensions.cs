using System;

namespace DotNetToolkit.Extensions
{
    public static class StringExtensions
    {

        public static bool IsEmptyString(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        public static bool IsNotEmptyString(this string text)
        {
            return !IsEmptyString(text);
        }

        public static string RemoveWhiteSpaces(this string text)
        {
            text = text.Trim().Replace(" ", "");
            return text;
        }

        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }


        public static bool IsForbiddenWord(this string text)
        {
            bool result = false;

            //Add the forbidden words here
            string[] forbiddenWords = new string[] { "null", "nul", "object" };

            text = text.ToLower().Trim();
            if (Array.IndexOf(forbiddenWords, text) >= 0) result = true;

            return result;
        }

    }
}
