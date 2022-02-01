using NUnit.Framework;
using OddEven;
using System;
using System.Collections.Generic;

namespace OddEvenTests
{
    public class Tests
    {
        [Test]
        public void RangeFrom1To100_ReturnsCorrectSequence()
        {
            var expected = new List<string>() { "Odd", "2", "3", "Even", "5", "Even", "7", "Even", "Odd", "Even", "11", "Even", "13", "Even", "Odd", "Even", "17", "Even", "19", "Even", "Odd", "Even", "23", "Even", "Odd", "Even", "Odd", "Even", "29", "Even", "31", "Even", "Odd", "Even", "Odd", "Even", "37", "Even", "Odd", "Even", "41", "Even", "43", "Even", "Odd", "Even", "47", "Even", "Odd", "Even", "Odd", "Even", "53", "Even", "Odd", "Even", "Odd", "Even", "59", "Even", "61", "Even", "Odd", "Even", "Odd", "Even", "67", "Even", "Odd", "Even", "71", "Even", "73", "Even", "Odd", "Even", "Odd", "Even", "79", "Even", "Odd", "Even", "83", "Even", "Odd", "Even", "Odd", "Even", "89", "Even", "Odd", "Even", "Odd", "Even", "Odd", "Even", "97", "Even", "Odd", "Even", };

            var actual = new List<string>(OddEvenGetter.GetOddEvenNumSequence(100));

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void IfNegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => OddEvenGetter.GetOddEvenNumSequence(-1));
        }

        [Test]
        public void IfZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => OddEvenGetter.GetOddEvenNumSequence(0));
        }

        [Test]
        public void RangeFrom1To1_ReturnsCorrectSequence()
        {
            var expected = new List<string>() { "Odd", };

            var actual = new List<string>(OddEvenGetter.GetOddEvenNumSequence(1));

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}