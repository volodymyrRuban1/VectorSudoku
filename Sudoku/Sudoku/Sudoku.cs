using System;
using System.Text;

namespace Sudoku
{
	public class Sudoku
	{
		private readonly int _sudokuSize;
		private readonly int _squareSize;
		private int[,] _sudoku;

		public Sudoku(int size)
		{
			if (!IsSizeValid(size))
			{
				throw new Exception("Size should be more than 1");
			}
			_squareSize = (int)Math.Sqrt(size);
			_sudokuSize = _squareSize * _squareSize;
			_sudoku = new int[_sudokuSize, _sudokuSize];
		}

		public int[,] SetCustomSudokuField
		{
			set => _sudoku = value;
		}

		public void FillSudokuWithRandomValues()
		{
			var rand = new Random();
			for (int i = 0; i < _sudokuSize; i++)
			{
				for (int j = 0; j < _sudokuSize; j++)
				{
					_sudoku[i,j] = rand.Next(Constants.MinNumber, _sudokuSize + 1);
				}
			}
		}

		public bool AreRowsValid()
		{
			for (int i = 0; i < _sudokuSize; i++)
			{
				for (int j = 0; j < _sudokuSize; j++)
				{
					var current = _sudoku[i, j];

					for (int k = j + 1; k < _sudokuSize; k++)
					{
						if (current.Equals(_sudoku[i, k]))
						{
							return false;
						}
					}

				}
			}
			return true;
		}

		public bool AreColumnsValid()
		{
			for (int i = 0; i < _sudokuSize; i++)
			{
				for (int j = 0; j < _sudokuSize; j++)
				{
					var current = _sudoku[j, i];

					for (int k = j + 1; k < _sudokuSize; k++)
					{
						if (current.Equals(_sudoku[k, i]))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		public bool AreSquaresValid()
		{
			for (int i = 0; i < _sudokuSize; i++)
			{
				var numbersInSquare = new bool[_sudokuSize + 1];
				for (int j = 0; j < _sudokuSize; j++)
				{
					var number = GetNumberFromSquare(i, j);
					if (number != 0 && numbersInSquare[number])
					{
						return false;
					}

					numbersInSquare[number] = true;
				}
			}
			return true;
		}

		public bool AreSquaresSizeValid() => (int)Math.Sqrt(_sudokuSize) == _squareSize;

		public bool IsSudokuValid() => AreRowsValid() && AreColumnsValid() 
		                                              && AreSquaresValid() 
		                                              && AreSquaresSizeValid();

		public override string ToString()
		{
			var builder = new StringBuilder();
			builder.Append("[");

			for (int i = 0; i < _sudokuSize; i++)
			{
				builder.AppendLine();

				if (IsIndexValidForNewLine(i))
				{
					builder.AppendLine();
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

		private bool IsIndexValidForNewLine(int index) => index % _squareSize == 0 && index != 0;

		private bool IsSizeValid(int size) => size > Constants.MinSize;

		private int GetNumberFromSquare(int y, int x)
		{
			var row = x / _squareSize + _squareSize * (y / _squareSize);
			var column = _squareSize * (y % _squareSize) + x % _squareSize;
			
			return _sudoku[row,column];
		}
	}
}
