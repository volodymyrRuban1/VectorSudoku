using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shapes
{
	public class Square : Shape
	{
		private readonly double _sideLength;

		public Square(double sideLength)
		{
			_sideLength = sideLength;
			Area = CalculateArea();
		}

		public double CalculateArea() => _sideLength * _sideLength;

		public override string ToString() => $"Square area = {Area}";
	}
}
