using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib.Shapes
{
	public class Rectangle : IShape
	{
		public double SideA;
		public double SideB;

		public Rectangle(double sideA, double sideB)
		{
			SideA = sideA;
			SideB = sideB;
		}

		public double CalculateSquare()
		{
			return SideA * SideB;
		}
	}
}
