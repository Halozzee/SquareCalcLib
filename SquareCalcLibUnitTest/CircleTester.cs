using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalcLib.Shapes;
using System;
using System.Diagnostics;

namespace SquareCalcLibUnitTest
{
	[TestClass]
	public class CircleTester
	{
		[TestMethod]
		public void TriangleTest1()
		{
			Circle t = new Circle(5);

			double square = Math.PI * 25;

			Assert.AreEqual(square, t.CalculateSquare());
		}

		[TestMethod]
		public void TriangleTest2()
		{
			Circle t = new Circle(3);

			double square = Math.PI * 9;

			Assert.AreEqual(square, t.CalculateSquare());
		}
	}
}
