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

            return true;
        }
    }
}
