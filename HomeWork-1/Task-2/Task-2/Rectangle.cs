using MathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
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

        private double perimetr;
        private double square;

        public double Perimetr
        {
            get
            {
                Tuple<double, double> twoSide = CountTwoSides();
                perimetr = 2 * twoSide.Item1 + 2 * twoSide.Item2;
                return perimetr;
            }
        }

        public double Square
        {
            get
            {
                Tuple<double, double> twoSide = CountTwoSides();
                square = twoSide.Item1 * twoSide.Item2;
                return square;
            }
        }

        public Tuple<double, double> CountTwoSides()
        {
            double oneSide = SquareRoot.sqrt((RightDownCoord.X - LeftUpCoord.X) * (RightDownCoord.X - LeftUpCoord.X) +
                (LeftUpCoord.Y - LeftUpCoord.Y) * (LeftUpCoord.Y - LeftUpCoord.Y));

            double secondSide = SquareRoot.sqrt((LeftUpCoord.X - LeftUpCoord.X) * (LeftUpCoord.X - LeftUpCoord.X) +
                (RightDownCoord.Y - LeftUpCoord.Y) * (RightDownCoord.Y - LeftUpCoord.Y));

            Tuple<double, double> twoSides = new Tuple<double, double>(oneSide, secondSide);

            return twoSides;
        }      
    }
}
