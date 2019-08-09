﻿using Common;
using System;

namespace Task_4
{
    public static class Rectangle
    {
        private static Tuple<double, double> CountTwoSides(Coordinate LeftUpCoord, Coordinate RightDownCoord)
        {
            double oneSide = MathHelper.SquareRoot((RightDownCoord.X - LeftUpCoord.X) * (RightDownCoord.X - LeftUpCoord.X) +
                (LeftUpCoord.Y - LeftUpCoord.Y) * (LeftUpCoord.Y - LeftUpCoord.Y));

            double secondSide = MathHelper.SquareRoot((LeftUpCoord.X - LeftUpCoord.X) * (LeftUpCoord.X - LeftUpCoord.X) +
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
