using System;
using System.Text;
using System.Linq;

namespace Sudoku
{
	public class Sudoku
	{
		private readonly int _sudokuSize;
		private readonly int _squareSize;
		private int[,] _sudoku;

		public Sudoku(int size)
		{
			
				
		}

		private bool IsSizeValid(int size) => size > Constants.MIN_SIZE;
		

		public void FillSudokuWithRandomValues()
		{
			
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
