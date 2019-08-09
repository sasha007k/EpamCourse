using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test static class Rectangle
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

            Console.Write("Perimetr: ");
            Console.WriteLine(Rectangle.Perimetr(leftUpCoordinate, rightDownCoordinate));

            Console.Write("Square: ");
            Console.WriteLine(Rectangle.Square(leftUpCoordinate, rightDownCoordinate));

            //Test static class Circle

            Console.Write("Input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Square = ");
            Console.WriteLine(Circle.Square(radius));

            Console.Write("Length = ");
            Console.WriteLine(Circle.Length(radius));

            Console.ReadKey();
        }
    }
}
