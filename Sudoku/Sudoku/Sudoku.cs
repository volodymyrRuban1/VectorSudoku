using System;
using System.Globalization;
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
			if (IsSizeValid(size))
			{
				_squareSize = (int)Math.Sqrt(size);
				_sudokuSize = _squareSize * _squareSize;
				_sudoku = new int[_sudokuSize, _sudokuSize];
			}
				
		}

		private bool IsSizeValid(int size) => size > Constants.MinSize;
		

		public void FillSudokuWithRandomValues()
		{
			var rand = new Random();
			for (int i = 0; i < _sudokuSize; i++)
			{
				for (int j = 0; j < _sudokuSize; j++)
				{
					_sudoku[i,j] = rand.Next(1, _sudokuSize + 1);
				}
			}
		}

		//public bool IsSudokuValid()
		//{

		//}

		public override string ToString()
		{
			var builder = new StringBuilder();
			builder.Append("[");

			for (int i = 0; i < _sudokuSize; i++)
			{
				builder.Append("\n");

				if (i % _squareSize == 0 && i != 0)
				{
					builder.Append("\n");
				}

				for (int j = 0; j < _sudokuSize; j++)
				{
					if (j % _squareSize == 0) 
						builder.Append("\t");

					if (j == 0)
						builder.Append("[");

					builder.Append(_sudoku[i, j]);

					if (j == _sudokuSize - 1)
						builder.Append("]");

					builder.Append(",");
				}
			}

			builder.Remove(builder.Length - 1, 1);
			builder.Append("\n]\n");

			return builder.ToString();
		}
	}
}
