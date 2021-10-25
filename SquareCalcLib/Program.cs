using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib.Shapes.Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Triangle t = new Triangle(4, 5, 6);

			double p = (4 + 5 + 6) / 2;
			double square = Math.Sqrt(p * (p - 4) * (p - 5) * (p - 6));

			Debug.WriteLine($"{p}:{square}");
		}
	}
}
