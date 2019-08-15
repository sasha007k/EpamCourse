using HomeWork_1;
using System;

namespace RunHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------- HomeWork 1 ---------------------------

            Console.WriteLine("Task-1 (HW - 1)"); // Task - 1

            Console.Write("Input left up X coordinate: ");
            int leftUpX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input left up Y coordinate: ");
            int leftUpY = Convert.ToInt32(Console.ReadLine());

            Coordinate leftUpCoordinate = new Coordinate(leftUpX, leftUpY);

            Console.Write("Input rigt down X coordinate: ");
            int rightDownX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input right down Y coordinate: ");
            int rightDownY = Convert.ToInt32(Console.ReadLine());

            Coordinate rightDownCoordinate = new Coordinate(rightDownX, rightDownY);

            Rectangle rectangle = new Rectangle(leftUpCoordinate, rightDownCoordinate);

            Console.Write("Perimetr: ");
            Console.WriteLine(rectangle.Perimetr());

            Console.Write("Square: ");
            Console.WriteLine(rectangle.Square());

            Console.ReadKey();

            Console.WriteLine("Task-2 (HW - 2)"); // Task - 2

            Console.Write("Input left up X coordinate: ");
            int leftUpX2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input left up Y coordinate: ");
            int leftUpY2 = Convert.ToInt32(Console.ReadLine());

            Coordinate leftUpCoordinate2 = new Coordinate(leftUpX2, leftUpY2);

            Console.Write("Input rigt down X coordinate: ");
            int rightDownX2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input right down Y coordinate: ");
            int rightDownY2 = Convert.ToInt32(Console.ReadLine());

            Coordinate rightDownCoordinate2 = new Coordinate(rightDownX2, rightDownY2);

            PropertyBasedRectangle rectangle2 = new PropertyBasedRectangle(leftUpCoordinate2, rightDownCoordinate2);

            Console.Write("Perimetr: ");
            Console.WriteLine(rectangle2.Perimetr);

            Console.Write("Square: ");
            Console.WriteLine(rectangle2.Square);

            Console.ReadKey();

            Console.WriteLine("Task-3 (HW - 3)"); // Task - 3

            Circle circle = new Circle();

            Console.Write("Input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Square = ");
            Console.WriteLine(circle.Square(radius));

            Console.Write("Length = ");
            Console.WriteLine(circle.Length(radius));

            Console.ReadKey();

            Console.WriteLine("Task-4 (HW - 4)"); // Task - 4

            //Test static class Rectangle
            Console.Write("Input left up X coordinate: ");
            int leftUpX4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input left up Y coordinate: ");
            int leftUpY4 = Convert.ToInt32(Console.ReadLine());

            Coordinate leftUpCoordinate4 = new Coordinate(leftUpX4, leftUpY4);

            Console.Write("Input rigt down X coordinate: ");
            int rightDownX4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input right down Y coordinate: ");
            int rightDownY4 = Convert.ToInt32(Console.ReadLine());

            Coordinate rightDownCoordinate4 = new Coordinate(rightDownX4, rightDownY4);

            Console.Write("Perimetr: ");
            Console.WriteLine(StaticRectangle.Perimetr(leftUpCoordinate, rightDownCoordinate));

            Console.Write("Square: ");
            Console.WriteLine(StaticRectangle.Square(leftUpCoordinate, rightDownCoordinate));

            //Test static class Circle

            Console.Write("Input radius: ");
            double radius4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Square = ");
            Console.WriteLine(StaticCircle.Square(radius));

            Console.Write("Length = ");
            Console.WriteLine(StaticCircle.Length(radius));

            Console.ReadKey();

            Console.WriteLine("Task-5 (HW - 5)"); // Task - 5

            Console.Write("Input real part: ");
            double realFirst = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input imaginary part: ");
            double imaginaryFirst = Convert.ToDouble(Console.ReadLine());

            ComplexNumber firstComplex = new ComplexNumber(realFirst, imaginaryFirst);

            Console.Write("Input real part: ");
            double realSecond = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input imaginary part: ");
            double imaginarySecond = Convert.ToDouble(Console.ReadLine());

            ComplexNumber secondComplex = new ComplexNumber(realSecond, imaginarySecond);

            ComplexNumber multiplyingResult = firstComplex * secondComplex;
            Console.WriteLine(multiplyingResult.ToString());

            ComplexNumber dividingResult = firstComplex / secondComplex;
            Console.WriteLine(dividingResult.ToString());

            Console.ReadKey();
        }
    }
}
