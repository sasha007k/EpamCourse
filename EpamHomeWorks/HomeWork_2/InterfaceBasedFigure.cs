using System;

namespace HomeWork_2
{
    public class InterfaceBasedFigure : IDrawable
    {
        protected int X { get; }
        protected int Y { get; }

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
