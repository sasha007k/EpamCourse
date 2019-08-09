using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
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
