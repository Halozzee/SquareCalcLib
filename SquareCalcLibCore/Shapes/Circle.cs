using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLibCore.Shapes
{
    public class Circle : IShape
    {
        public double R;

        public Circle(double r)
        {
            R = r;
        }

        public double CalculateSquare()
        {
            return Math.Pow(R, 2) * Math.PI;
        }
    }
}
