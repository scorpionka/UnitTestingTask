using NUnit.Framework;
using Sudoku;
using Sudoku.SudokuValidationTool;
using Sudoku.SudokuValidationTool.Interfaces;
using System;
using System.Collections.Generic;

namespace SudokuTests
{
    public class Tests
    {
        private ISudokuValidationTool sudokuValidationTool;

        [SetUp]
        public void Setup()
        {
            sudokuValidationTool = new SudokuValidationTool();
        }

        [Test]
        public void SudokuTableIsNull_ThrowsArgumentNullException()
        {
            SudokuTable sudokuTable = new SudokuTable(null);

            Assert.Throws<ArgumentNullException>(() => sudokuValidationTool.ValidateSolution(sudokuTable));
        }

        public static IEnumerable<TestCaseData> SudokuSizeTest()
        {
            yield return new TestCaseData(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
        }

        [Test]
        [TestCaseSource("SudokuSizeTest")]
        public void SudokuTableHasWrongSize_ReturnsFalse(int[,] table)
        {
            SudokuTable sudokuTable = new SudokuTable(table);

            Assert.IsFalse(sudokuValidationTool.ValidateSolution(sudokuTable));
        }

        public static IEnumerable<TestCaseData> SudokuZeroTest()
        {
            yield return new TestCaseData(new int[,]
                             { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                               { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                               { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                               { 8, 5, 9, 0, 6, 1, 4, 2, 3 },
                               { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                               { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                               { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                               { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                               { 3, 4, 5, 2, 8, 6, 1, 7, 9 } });
        }

        [Test]
        [TestCaseSource("SudokuZeroTest")]
        public void SudokuTableContainsZero_ReturnsFalse(int[,] table)
        {
            SudokuTable sudokuTable = new SudokuTable(table);

            Assert.IsFalse(sudokuValidationTool.ValidateSolution(sudokuTable));
        }

        public static IEnumerable<TestCaseData> SudokuNegativeNumberTest()
        {
            yield return new TestCaseData(new int[,]
                             { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                               { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                               { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                               { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                               { 4, 2, 6, 8, 5, 3, -7, 9, 1 },
                               { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                               { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                               { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                               { 3, 4, 5, 2, 8, 6, 1, 7, 9 } });
        }

        [Test]
        [TestCaseSource("SudokuNegativeNumberTest")]
        public void SudokuTableContainsNegativeNumber_ReturnsFalse(int[,] table)
        {
            SudokuTable sudokuTable = new SudokuTable(table);

            Assert.IsFalse(sudokuValidationTool.ValidateSolution(sudokuTable));
        }

        public static IEnumerable<TestCaseData> SudokuWrongNumberTest()
        {
            yield return new TestCaseData(new int[,]
                             { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                               { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                               { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                               { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                               { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                               { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                               { 9, 6, 11, 5, 3, 7, 2, 8, 4 },
                               { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                               { 3, 4, 5, 2, 8, 6, 1, 7, 9 } });
        }

        [Test]
        [TestCaseSource("SudokuWrongNumberTest")]
        public void SudokuTableContainsWrongNumber_ReturnsFalse(int[,] table)
        {
            SudokuTable sudokuTable = new SudokuTable(table);

            Assert.IsFalse(sudokuValidationTool.ValidateSolution(sudokuTable));
        }

        public static IEnumerable<TestCaseData> SudokuIncorrectTableTest()
        {
            yield return new TestCaseData(new int[,]
                             { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                               { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                               { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                               { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                               { 4, 2, 6, 8, 5, 8, 7, 9, 1 },
                               { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                               { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                               { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                               { 3, 4, 5, 2, 8, 6, 1, 7, 9 } });
        }

        [Test]
        [TestCaseSource("SudokuIncorrectTableTest")]
        public void SudokuTableIsIncorrect_ReturnsFalse(int[,] table)
        {
            SudokuTable sudokuTable = new SudokuTable(table);

            Assert.IsFalse(sudokuValidationTool.ValidateSolution(sudokuTable));
        }

        public static IEnumerable<TestCaseData> SudokuCorrectTableTest()
        {
            yield return new TestCaseData(new int[,]
                             { { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                               { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                               { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                               { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                               { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                               { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                               { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                               { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                               { 3, 4, 5, 2, 8, 6, 1, 7, 9 } });
        }

        [Test]
        [TestCaseSource("SudokuCorrectTableTest")]
        public void SudokuTableIsCorrect_ReturnsTrue(int[,] table)
        {
            SudokuTable sudokuTable = new SudokuTable(table);

            Assert.IsTrue(sudokuValidationTool.ValidateSolution(sudokuTable));
        }
    }
}