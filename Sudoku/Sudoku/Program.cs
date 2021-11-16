	using System;
	using System.Reflection.Metadata.Ecma335;

	namespace Sudoku
{
	class Program
	{
		static void Main(string[] args)
		{
			var sudoku = new Sudoku(15);
			sudoku.FillSudokuWithRandomValues();
			Console.WriteLine(sudoku);

		}
	}
}
