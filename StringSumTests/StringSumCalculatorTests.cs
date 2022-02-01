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

        [TestCase("123", "587", "710")]
        [TestCase("3859425", "4796323", "8655748")]
        [TestCase("1355964", "10244691", "11600655")]
        public void NumbersAreNatural_ReturnsCorrectResult(string num1, string num2, string expected)
        {
            Assert.AreEqual(expected, StringSumCalculator.Sum(num1, num2));
        }

        [TestCase("1355964", "10244691", "5")]
        public void NumbersAreNatural_ReturnsIncorrectResult(string num1, string num2, string expected)
        {
            Assert.AreNotEqual(expected, StringSumCalculator.Sum(num1, num2));
        }

        [Test]
        public void NumbersAreTooBig_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => StringSumCalculator.Sum("18446744073709551616", "1"));
            Assert.Throws<FormatException>(() => StringSumCalculator.Sum("5", "18446744073709551619"));
            Assert.Throws<FormatException>(() => StringSumCalculator.Sum("9223372036854775811", "9223372036854775900"));
        }
    }
}