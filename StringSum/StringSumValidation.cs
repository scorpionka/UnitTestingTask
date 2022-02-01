using System;

namespace StringSum
{
    internal static class StringSumValidation
    {
        internal static void ValidateNumber(string num)
        {
            if (num is null)
                throw new ArgumentNullException(nameof(num));

            if (string.IsNullOrWhiteSpace(num))
                throw new ArgumentException($"{num} is empty string", nameof(num));
        }

        /// <summary>
        /// Check if natural number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>If natural, returns <param name="num"/>, else returns "0"</returns>
        internal static string CheckIfNatural(string num)
        {
            foreach (char c in num)
            {
                if (!char.IsDigit(c))
                    return "0";
            }

            return num;
        }
    }
}
