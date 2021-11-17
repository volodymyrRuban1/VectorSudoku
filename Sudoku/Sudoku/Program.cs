	using System;

	namespace Sudoku
{
	class Program
	{
		static void Main(string[] args)
		{
			const int sudokuSize = 4;

			PrintSudoku(sudokuSize);

			var mySudoku = new int[sudokuSize, sudokuSize]
			{
				{2, 3, 1, 4}, {4, 1, 3, 2},
				{3, 4, 2, 1}, {1, 2, 4, 3}
			};

			PrintSudoku((int)Math.Sqrt(mySudoku.Length), mySudoku);

		}

		public static void PrintSudoku(int sudokuSize, int[,] customSudoku = null)
		{
			var sudoku = new Sudoku(sudokuSize);

			if(customSudoku is null)
				sudoku.FillSudokuWithRandomValues();
			else
				sudoku.SetCustomSudokuField = customSudoku;

			Console.WriteLine(sudoku);

			Console.WriteLine(new string('-', 30));


			Console.WriteLine("Are rows valid: {0}", sudoku.AreRowsValid());

			Console.WriteLine("Are columns valid: {0}", sudoku.AreColumnsValid());

			Console.WriteLine("Are squares valid: {0}", sudoku.AreSquaresValid());

			Console.WriteLine("Is sudoku valid : {0}", sudoku.IsSudokuValid());

			Console.WriteLine(new string('-', 30));
		}
	}
}
