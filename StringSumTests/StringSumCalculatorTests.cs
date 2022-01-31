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
        public void NumbersAreEmptyStrings_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => StringSumCalculator.Sum(string.Empty, string.Empty));
        }
    }
}