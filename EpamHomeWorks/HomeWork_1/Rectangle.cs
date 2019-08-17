using System;

namespace HomeWork_1
{
    public class Rectangle
    {
        private readonly Coordinate leftUpCoord;
        private readonly Coordinate rightDownCoord;

        public Rectangle(Coordinate leftUpCoord, Coordinate rightDownCoord)
        {
            this.leftUpCoord = leftUpCoord;
            this.rightDownCoord = rightDownCoord;
        }

        private Tuple<double, double> CountTwoSides()
        {           
            double oneSide = MathHelper.SquareRoot((rightDownCoord.X - leftUpCoord.X) * (rightDownCoord.X - leftUpCoord.X));
            double secondSide = MathHelper.SquareRoot((rightDownCoord.Y - leftUpCoord.Y) * (rightDownCoord.Y - leftUpCoord.Y));

            Tuple<double, double> twoSides = new Tuple<double, double>(oneSide, secondSide);

            return twoSides;
        }

        public double Perimetr()
        {
            Tuple<double, double> twoSide = CountTwoSides();

            return 2 * twoSide.Item1 + 2 * twoSide.Item2;
        }

        public double Square()
        {
            Tuple<double, double> twoSide = CountTwoSides();

            return twoSide.Item1 * twoSide.Item2;
        }
    }
}
