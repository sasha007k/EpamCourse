using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Rectangle
    {
        Coordinate LeftUpCoord;
        Coordinate RightDownCoord;

        public Rectangle(Coordinate LeftUpCoord, Coordinate RightDownCoord)
        {
            this.LeftUpCoord = LeftUpCoord;
            this.RightDownCoord = RightDownCoord;
        }

        public Tuple<double, double> CountTwoSides()
        {
            double oneSide = MathHelper.SquareRoot((RightDownCoord.X - LeftUpCoord.X) * (RightDownCoord.X - LeftUpCoord.X) +
                (LeftUpCoord.Y - LeftUpCoord.Y) * (LeftUpCoord.Y - LeftUpCoord.Y));

            double secondSide = MathHelper.SquareRoot((LeftUpCoord.X - LeftUpCoord.X) * (LeftUpCoord.X - LeftUpCoord.X) +
                (RightDownCoord.Y - LeftUpCoord.Y) * (RightDownCoord.Y - LeftUpCoord.Y));

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
