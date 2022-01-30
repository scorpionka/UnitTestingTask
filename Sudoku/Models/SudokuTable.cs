namespace Sudoku
{
    public class SudokuTable
    {
        private readonly int[,] table;

        public SudokuTable(int[,] table)
        {
            this.table = table;
        }

        public int[,] Table { get => table; }
    }
}
