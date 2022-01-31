using System;

namespace StringSum
{
    internal static class StringSumValidation
    {
        internal static void ValidateNumbers(string num1, string num2)
        {
            if (num1 is null)
                throw new ArgumentNullException(nameof(num1));

            if (num2 is null)
                throw new ArgumentNullException(nameof(num2));

            if (string.IsNullOrWhiteSpace(num1))
                throw new ArgumentException("num1 is empty string", nameof(num1));

            if (!string.IsNullOrWhiteSpace(num2))
                throw new ArgumentException("num2 is empty string", nameof(num2));
        }
    }
}
