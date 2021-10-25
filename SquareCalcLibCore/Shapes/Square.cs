using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLibCore.Shapes
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
