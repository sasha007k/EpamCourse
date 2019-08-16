using System;

namespace HomeWork_2
{
    public class InterfaceBasedRectangle : InterfaceBasedFigure, IDrawable
    {
        public InterfaceBasedRectangle(int x, int y)
            : base(x, y)
        {

        }

        public new void Draw()
        {
            Console.WriteLine("Class Rectangle based on interface");
        }
    }
}
