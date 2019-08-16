using System;

namespace HomeWork_2
{
    public class VirtualMethodBasedSquare : VirtualMethodBasedFigure
    {
        public VirtualMethodBasedSquare(int x, int y)
            : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Class Square based on virtual method");
        }
    }
}
