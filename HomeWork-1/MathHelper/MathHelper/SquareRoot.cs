using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class SquareRoot
    {
        public static double sqrt(double number)
        {
            double t;
            double squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;
            }
            while ((t - squareRoot) != 0);

            return squareRoot;
        }
    }
}
