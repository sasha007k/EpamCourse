namespace HomeWork_2
{
    public abstract class FigureWithConstructor
    {
        protected readonly int X;
        protected readonly int Y;

        protected FigureWithConstructor(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw();
    }
}
