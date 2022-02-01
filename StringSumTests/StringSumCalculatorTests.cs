using NUnit.Framework;
using StringSum;
using System;

namespace StringSumTests
{
    public class Tests
    {
        [Test]
        public void NumbersAreNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => StringSumCalculator.Sum(null, null));
            Assert.Throws<ArgumentNullException>(() => StringSumCalculator.Sum("5", null));
            Assert.Throws<ArgumentNullException>(() => StringSumCalculator.Sum(null, "3"));
        }

        [Test]
        public void NumbersAreEmptyStrings_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => StringSumCalculator.Sum(string.Empty, string.Empty));
            Assert.Throws<ArgumentException>(() => StringSumCalculator.Sum("5", string.Empty));
            Assert.Throws<ArgumentException>(() => StringSumCalculator.Sum(string.Empty, "3"));
        }

        [TestCase("-2", "5", "5")]
        [TestCase("-5", "-5", "0")]
        [TestCase("5", "-3", "5")]
        public void NumbersAreNegative_ReturnsCorrectResult(string num1, string num2, string expected)
        {
            Assert.AreEqual(expected, StringSumCalculator.Sum(num1, num2));
        }

        [TestCase("a87", "5", "5")]
        [TestCase("null", "25ty", "0")]
        [TestCase("5", "fg57y", "5")]
        public void NumbersAreNotNatural_ReturnsCorrectResult(string num1, string num2, string expected)
        {
            Assert.AreEqual(expected, StringSumCalculator.Sum(num1, num2));
        }
    }
}