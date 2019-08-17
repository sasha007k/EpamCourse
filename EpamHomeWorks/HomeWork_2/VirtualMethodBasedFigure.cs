using System;

namespace HomeWork_2
{
    public class VirtualMethodBasedFigure
    {
        protected int X { get; }
        protected int Y { get; }

        public VirtualMethodBasedFigure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Class Figure based on virtual method");
        }
    }
}
