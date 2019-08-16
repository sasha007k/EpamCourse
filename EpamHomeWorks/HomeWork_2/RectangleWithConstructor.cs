using System;

namespace HomeWork_2
{
    public class RectangleWithConstructor : FigureWithConstructor
    {
        public RectangleWithConstructor(int x, int y)
            : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Class Rectangle with constructor");
        }
    }
}
