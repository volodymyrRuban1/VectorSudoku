using System;

namespace OOP.Shapes
{
	public class Circle : Shape
	{
		private readonly double _radius;

		public Circle(double radius)
		{
			_radius = radius;
			Area = CalculateArea();
		}

		private double CalculateArea() => _radius * _radius * Math.PI;

		public override string ToString() => $"Circle area = {Area}";
	}
}
