using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shapes
{
	public abstract class Shape : IComparable
	{
		protected double Area;

		public int CompareTo(object obj)
		{
			var shape = (Shape) obj;
			return (int)(Area - shape.Area);
		}
	}
}
