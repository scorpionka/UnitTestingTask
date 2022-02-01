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


            ulong ulongNum1 = ConvertToNumber(num1);
            ulong ulongNum2 = ConvertToNumber(num2);

            if (ulong.MaxValue - ulongNum1 < ulongNum2)
            {
                throw new FormatException($"Numbers are too big");
            }

            return (ulongNum1 + ulongNum2).ToString();
        }

        private static ulong ConvertToNumber(string num)
        {
            if (ulong.TryParse(num, out ulong numValue))
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
