using System;

namespace HomeWork_1
{
    public static class StaticRectangle
    {
        private static Tuple<double, double> CountTwoSides(Coordinate leftUpCoord, Coordinate rightDownCoord)
        {
            double oneSide = MathHelper.SquareRoot((rightDownCoord.X - leftUpCoord.X) * (rightDownCoord.X - leftUpCoord.X));
            double secondSide = MathHelper.SquareRoot((rightDownCoord.Y - leftUpCoord.Y) * (rightDownCoord.Y - leftUpCoord.Y));

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
