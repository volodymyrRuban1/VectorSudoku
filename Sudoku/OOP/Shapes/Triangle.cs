using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shapes
{
	public class Triangle : Shape
	{
		private readonly double _base;

		private readonly double _height;
		public Triangle(double baseVal, double height)
		{
			_base = baseVal;
			_height = height;
			Area = CalculateArea();
		}

		private double CalculateArea() => _base * _height / 2;

		public override string ToString() => $"Triangle area = {Area}";
	}
}
