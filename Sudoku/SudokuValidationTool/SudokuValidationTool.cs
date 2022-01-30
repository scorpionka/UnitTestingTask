using Sudoku.SudokuValidationTool.Interfaces;
using System;

namespace Sudoku.SudokuValidationTool
{
    public class SudokuValidationTool : ISudokuValidationTool
    {
        private int[,] table;

        public bool IsValidSolution(SudokuTable sudokuTable)
        {
            if (sudokuTable == null) throw new ArgumentNullException(nameof(sudokuTable));

            if (sudokuTable.Table == null) throw new ArgumentNullException(nameof(sudokuTable));

            int rows = sudokuTable.Table.GetUpperBound(0) + 1;
            int columns = sudokuTable.Table.Length / rows;

            if (rows != 9 || columns != 9)
            {
                return false;
            }

            if (IsContainsWrongNumber(sudokuTable.Table))
            {
                return false;
            }

            table = sudokuTable.Table;

            return IsValidSudoku();
        }

        private static bool IsContainsWrongNumber(int[,] table)
        {
            foreach (int i in table)
            {
                if (i < 1 || i > 9) { return true; }
            }

            return false;
        }

        private bool IsValidSudoku()
        {
            return RowsAreValid()
                && ColumnsAreValid()
                && SquaresAreValid();
        }

        private bool RowsAreValid()
        {
            return IsValid(GetNumberFromRow);
        }

        private bool ColumnsAreValid()
        {
            return IsValid(GetNumberFromColumn);
        }

        private bool SquaresAreValid()
        {
            return IsValid(GetNumberFromSquare);
        }

        private static bool IsValid(Func<int, int, int> numberGetter)
        {
            for (int row = 0; row < 9; row++)
            {
                bool[] usedNumbers = new bool[10];
                for (int column = 0; column < 9; column++)
                {
                    int number = numberGetter(row, column);
                    if (number != 0 && usedNumbers[number] == true)
                    {
                        return false;
                    }

                    usedNumbers[number] = true;
                }
            }

            return true;
        }

        private int GetNumberFromRow(int row, int column)
        {
            return table[row, column];
        }

        private int GetNumberFromColumn(int row, int column)
        {
            return table[column, row];
        }

        private int GetNumberFromSquare(int block, int index)
        {
            int column = 3 * (block % 3) + index % 3;
            int row = index / 3 + 3 * (block / 3);
            return table[row, column];
        }
    }
}
