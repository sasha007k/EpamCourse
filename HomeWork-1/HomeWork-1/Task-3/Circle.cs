using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Circle
    {
        const double Pi = 3.14159265359;

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
