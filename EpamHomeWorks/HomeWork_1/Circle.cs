using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    public class Circle
    {
        private const double Pi = 3.14159265359;

        public double Square(double radius)
        {
            return Pi * radius * radius;
        }

        public double Length(double radius)
        {
            return 2 * Pi * radius;
        }
    }
}
