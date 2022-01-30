using Sudoku.SudokuValidationTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.SudokuValidationTool
{
    public class SudokuValidationTool : ISudokuValidationTool
    {
        public bool ValidateSolution(SudokuTable sudokuTable)
        {
            if (sudokuTable == null) throw new ArgumentNullException(nameof(sudokuTable));

            if (sudokuTable.Table == null) throw new ArgumentNullException(nameof(sudokuTable));

            int rows = sudokuTable.Table.GetUpperBound(0) + 1;
            int columns = sudokuTable.Table.Length / rows;

            if (rows != 9 || columns != 9)
            {
                return false;
            }

            if (CheckForWrongNumber(sudokuTable.Table))
            {
                return false;
            }

            return true;
        }

        private static bool CheckForWrongNumber(int[,] table)
        {
            foreach (int i in table)
            {
                if (i < 1 || i > 9) { return true; }
            }

            return false;
        }
    }
}
