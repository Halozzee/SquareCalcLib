using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib.Shapes
{
	public class Triangle : IShape
	{
		public double SideA;
		public double SideB;
		public double SideC;

		public Triangle(double sideA, double sideB, double sideC)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public bool IsSquareTriangle()
		{
			var pickArr = new[] {
				SideA,
				SideB,
				SideC
			};

			double hyp = pickArr.Max();
			double lowest = pickArr.Min();
			double otherSide = Math.Sqrt(Math.Pow(hyp, 2) - Math.Pow(lowest, 2));

			if (SideA == otherSide || SideB == otherSide || SideC == otherSide)
				return true;
			else
				return false;
		}

		public double CalculateSquare()
		{
			double p = (SideA + SideB + SideC) / 2;
			return Math.Sqrt(p * (p-SideA) * (p - SideB) * (p - SideC));
		}
	}
}
