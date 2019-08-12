using Common;
using System;

namespace Task_2
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

        public double Perimetr
        {
            get
            {
                Tuple<double, double> twoSide = CountTwoSides();
                return 2 * twoSide.Item1 + 2 * twoSide.Item2;
            }
        }

        public double Square
        {
            get
            {
                Tuple<double, double> twoSide = CountTwoSides();
                return twoSide.Item1 * twoSide.Item2;
            }
        }

        private Tuple<double, double> CountTwoSides()
        {
            double oneSide = MathHelper.SquareRoot((rightDownCoord.X - leftUpCoord.X) * (rightDownCoord.X - leftUpCoord.X) +
                (leftUpCoord.Y - leftUpCoord.Y) * (leftUpCoord.Y - leftUpCoord.Y));

            double secondSide = MathHelper.SquareRoot((leftUpCoord.X - leftUpCoord.X) * (leftUpCoord.X - leftUpCoord.X) +
                (rightDownCoord.Y - leftUpCoord.Y) * (rightDownCoord.Y - leftUpCoord.Y));

            Tuple<double, double> twoSides = new Tuple<double, double>(oneSide, secondSide);

            return twoSides;
        }
    }
}
