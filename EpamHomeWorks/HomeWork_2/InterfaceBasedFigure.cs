using System;

namespace HomeWork_2
{
    public class InterfaceBasedFigure : IDrawable
    {
        protected readonly int X;
        protected readonly int Y;

        public InterfaceBasedFigure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine("Class Figure based on interface");
        }
    }
}
