using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(rectangle.Perimetr);

            Console.Write("Square: ");
            Console.WriteLine(rectangle.Square);

            Console.ReadKey();
        }
    }
}
