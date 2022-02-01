using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEven
{
    public static class OddEvenGetter
    {
        public static IEnumerable<string> GetOddEvenNumSequence(int lastNumber)
        {
            if (lastNumber < 1)
            {
                throw new ArgumentException("Parameter must be greater than 0", nameof(lastNumber));
            }

            return GetSequence(lastNumber);
        }

        private static IEnumerable<string> GetSequence(int lastNumber)
        {
            foreach (int num in Enumerable.Range(1, lastNumber))
            {
                if (IsPrime(num))
                {
                    yield return num.ToString();
                }
                else if (num % 2 == 0)
                {
                    yield return "Even";
                }
                else
                {
                    yield return "Odd";
                }
            }
        }

        private static bool IsPrime(int num)
        {
            if (num > 1)
            {
                return Enumerable.Range(1, num).Where(x => num % x == 0)
                                 .SequenceEqual(new[] { 1, num });
            }

            return false;
        }
    }
}
