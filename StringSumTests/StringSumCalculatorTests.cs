using NUnit.Framework;
using StringSum;
using System;

namespace StringSumTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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
    }
}