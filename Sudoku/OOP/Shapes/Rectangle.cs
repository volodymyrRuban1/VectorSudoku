namespace OOP.Shapes
{
	public class Rectangle : Shape
	{
		private readonly double _height;

		private readonly double _width;
		public Rectangle(double height, double width)
		{
			_height = height;
			_width = width;
			Area = CalculateArea();
		}

		private double CalculateArea() => _height * _width;

		public override string ToString() => $"Rectangle area = {Area}";
	}
}
