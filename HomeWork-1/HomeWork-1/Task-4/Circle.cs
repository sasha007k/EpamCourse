using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public static class Circle
    {
        private static readonly double Pi = 3.14159265359;

        public static double Square(double radius)
        {
            return Pi * radius * radius;
        }

        public static double Length(double radius)
        {
            return 2 * Pi * radius;
        }
    }
}
