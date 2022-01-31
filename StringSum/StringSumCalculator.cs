using System;

namespace StringSum
{
    public class StringSumCalculator
    {
        public static string Sum(string num1, string num2)
        {
            StringSumValidation.ValidateNumbers(num1, num2);

            return num1 + num2;
        }
    }
}
