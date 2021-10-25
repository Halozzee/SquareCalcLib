using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalcLibCore.Shapes;
using System;
using System.Diagnostics;

namespace SquareCalcLibUnitTest
{
	[TestClass]
	public class TriangleTester
	{
		[TestMethod]
		public void TriangleTest1()
		{
			Triangle t = new Triangle(3,4,5);

			double p = (3 + 4 + 5) / 2;
			double square = Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5));

			Assert.AreEqual(square, t.CalculateSquare());
			Assert.IsTrue(t.IsSquareTriangle());
		}

		[TestMethod]
		public void TriangleTest2()
		{
			Triangle t = new Triangle(4, 5, 6);

			double p = (4 + 5 + 6) / 2.0;
			double square = Math.Sqrt(p * (p - 4) * (p - 5) * (p - 6));

			Debug.WriteLine($"{p}:{square}");

			Assert.AreEqual(square, t.CalculateSquare());
			Assert.IsFalse(t.IsSquareTriangle());
		}
	}
}
