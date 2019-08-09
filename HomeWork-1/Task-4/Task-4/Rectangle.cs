using MathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public static class Rectangle
    {
        public static Tuple<double, double> CountTwoSides(Coordinate LeftUpCoord, Coordinate RightDownCoord)
        {
            double oneSide = SquareRoot.sqrt((RightDownCoord.X - LeftUpCoord.X) * (RightDownCoord.X - LeftUpCoord.X) +
                (LeftUpCoord.Y - LeftUpCoord.Y) * (LeftUpCoord.Y - LeftUpCoord.Y));

            double secondSide = SquareRoot.sqrt((LeftUpCoord.X - LeftUpCoord.X) * (LeftUpCoord.X - LeftUpCoord.X) +
                (RightDownCoord.Y - LeftUpCoord.Y) * (RightDownCoord.Y - LeftUpCoord.Y));

            Tuple<double, double> twoSides = new Tuple<double, double>(oneSide, secondSide);

            return twoSides;
        }

        public static double Perimetr(Coordinate LeftUpCoord, Coordinate RightDownCoord)
        {
            Tuple<double, double> twoSide = CountTwoSides(LeftUpCoord, RightDownCoord);

            return 2 * twoSide.Item1 + 2 * twoSide.Item2;
        }

        public static double Square(Coordinate LeftUpCoord, Coordinate RightDownCoord)
        {
            Tuple<double, double> twoSide = CountTwoSides(LeftUpCoord, RightDownCoord);

            return twoSide.Item1 * twoSide.Item2;
        }
    }
}
