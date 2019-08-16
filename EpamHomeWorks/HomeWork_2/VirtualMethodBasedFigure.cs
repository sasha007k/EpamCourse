using System;

namespace HomeWork_2
{
    public class VirtualMethodBasedFigure
    {
        protected readonly int X;
        protected readonly int Y;

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
