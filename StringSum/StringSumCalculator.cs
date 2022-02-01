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

            return num1 + num2;
        }
    }
}
