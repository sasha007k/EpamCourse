using System;

namespace HomeWork_2
{
    public class InterfaceBasedSquare : InterfaceBasedFigure, IDrawable
    {
        public InterfaceBasedSquare(int x, int y)
            : base(x, y)
        {

        }

        public new void Draw()
        {
            Console.WriteLine("Class Square based on interface");
        }
    }
}
