using System;

namespace StringSum
{
    public class StringSumCalculator
    {
        public static string Sum(string num1, string num2)
        {
            StringSumValidation.ValidateNumber(num1);
            StringSumValidation.ValidateNumber(num2);

            num1 = num1.Trim();
            num2 = num2.Trim();

            num1 = StringSumValidation.CheckIfNatural(num1);
            num2 = StringSumValidation.CheckIfNatural(num2);

            return (ConvertToNumber(num1) + ConvertToNumber(num2)).ToString();
        }

        private static long ConvertToNumber(string num)
        {
            if (long.TryParse(num, out long numValue))
            {
                return numValue;
            }
            else
            {
                throw new FormatException($"long.TryParse could not parse '{num}' to an long.");
            }
        }
    }
}
