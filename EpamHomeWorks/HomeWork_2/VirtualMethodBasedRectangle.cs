using System;

namespace HomeWork_2
{
    public class VirtualMethodBasedRectangle : VirtualMethodBasedFigure
    {
        public VirtualMethodBasedRectangle(int x, int y)
            : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Class Rectangle based on virtual method");
        }
    }
}
