using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.Write("Input radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Square = ");
            Console.WriteLine(circle.Square(radius));

            Console.Write("Length = ");
            Console.WriteLine(circle.Length(radius));

            Console.ReadKey();
        }
    }
}
