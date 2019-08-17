namespace HomeWork_2
{
    public abstract class FigureWithConstructor
    {
        protected int X { get; }
        protected int Y { get; }

        protected FigureWithConstructor(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw();
    }
}
