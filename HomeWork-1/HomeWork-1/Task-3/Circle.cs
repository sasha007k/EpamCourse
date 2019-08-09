namespace Task_3
{
    public class Circle
    {
        private const double Pi = 3.14159265359;

        public double Square(double radius)
        {
            return Pi * radius * radius;
        }

        public double Length(double radius)
        {
            return 2 * Pi * radius;
        }
    }
}
