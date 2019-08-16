using System;

namespace HomeWork_2
{
    public class SquareWithConstructor : FigureWithConstructor
    {
        public SquareWithConstructor(int x, int y)
            : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Class Square with constructor");
        }
    }
}
