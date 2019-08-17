using System;

namespace HomeWork_1
{
    public class PropertyBasedRectangle
    {
        private readonly Coordinate leftUpCoord;
        private readonly Coordinate rightDownCoord;

        public PropertyBasedRectangle(Coordinate leftUpCoord, Coordinate rightDownCoord)
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
            //double oneSide = MathHelper.SquareRoot((rightDownCoord.X - leftUpCoord.X) * (rightDownCoord.X - leftUpCoord.X) +
            //    (leftUpCoord.Y - leftUpCoord.Y) * (leftUpCoord.Y - leftUpCoord.Y));

            //double secondSide = MathHelper.SquareRoot((leftUpCoord.X - leftUpCoord.X) * (leftUpCoord.X - leftUpCoord.X) +
            //    (rightDownCoord.Y - leftUpCoord.Y) * (rightDownCoord.Y - leftUpCoord.Y));

            double oneSide = MathHelper.SquareRoot((rightDownCoord.X - leftUpCoord.X) * (rightDownCoord.X - leftUpCoord.X));
            double secondSide = MathHelper.SquareRoot((rightDownCoord.Y - leftUpCoord.Y) * (rightDownCoord.Y - leftUpCoord.Y));

            Tuple<double, double> twoSides = new Tuple<double, double>(oneSide, secondSide);

            return twoSides;
        }
    }
}
