using System;
using System.Collections.Generic;
using OOP.Shapes;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			var side = 1.1234D;
			var radius = 1.1234D;
			var baseValue = 5D;
			var height = 2D;
			var shapes = new List<Shape>{ new Square(side),
				new Circle(radius),
				new Triangle(baseValue, height) };
			shapes.Sort();
			foreach (var shape in shapes)
			{
				Console.WriteLine(shape);
			}
		}
	}
}
