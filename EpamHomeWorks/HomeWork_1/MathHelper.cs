﻿namespace HomeWork_1
{
    public static class MathHelper
    {
        public static double SquareRoot(double number)
        {
            double t;
            double squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;
            }
            while ((t - squareRoot) != 0);

            return squareRoot;
        }
    }
}
