using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalcLib.Shapes;
using System;

namespace SquareCalcLibUnitTest
{
	[TestClass]
	public class SquareTester
	{
		[TestMethod]
		public void SquareTest1()
		{
			Rectangle r = new Rectangle(2,4);

			double square = 2 * 4;

			Assert.AreEqual(square, r.CalculateSquare());
		}

		[TestMethod]
		public void SquareTest2()
		{
			Rectangle r = new Rectangle(1, 543);

			double square = 1 * 543;

			Assert.AreEqual(square, r.CalculateSquare());
		}
	}
}
