using System;

namespace Sudoku
{
    public class SudokuTable
    {
        public SudokuTable(int[,] sudokuTable)
        {
            Table = sudokuTable ?? throw new ArgumentNullException(nameof(sudokuTable));
        }

        public int[,] Table { get; private set; }
    }
}
