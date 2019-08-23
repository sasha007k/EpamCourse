using System;
using HomeWork_1;
using HomeWork_2;
using HomeWork_3;

namespace RunHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunFirstHomeWork();
            //RunSecondHomeWork();
            RunThirdHomeWork();
        }

        public static void InputUserData(out int inputData, string text)
        {
            while (!int.TryParse(Console.ReadLine(), out inputData))
            {
                Console.WriteLine("Value is not correct. Try again");
                Console.Write(text);
            }
        }

        public static void InputUserData(out double inputData, string text)
        {
            while (!double.TryParse(Console.ReadLine(), out inputData))
            {
                Console.WriteLine("Value is not correct. Try again");
                Console.Write(text);
            }
        }

        public static void RunFirstHomeWork()
        {
            Console.WriteLine("-------------------- HomeWork 1 ---------------------------"); //HomeWork 1

            Console.WriteLine("Task-1 (HW - 1)"); // Task - 1

            Console.Write("Input left up X coordinate: ");
            InputUserData(out int leftUpX, "Input left up X coordinate: ");

            Console.Write("Input left up Y coordinate: ");
            InputUserData(out int leftUpY, "Input left up Y coordinate: ");

            Coordinate leftUpCoordinate = new Coordinate(leftUpX, leftUpY);

            Console.Write("Input rigt down X coordinate: ");
            InputUserData(out int rightDownX, "Input rigt down X coordinate: ");

            Console.Write("Input right down Y coordinate: ");
            InputUserData(out int rightDownY, "Input rigt down Y coordinate: ");

            Coordinate rightDownCoordinate = new Coordinate(rightDownX, rightDownY);

            HomeWork_1.Rectangle rectangle = new HomeWork_1.Rectangle(leftUpCoordinate, rightDownCoordinate);

            Console.Write("Perimetr: ");
            Console.WriteLine(rectangle.Perimetr());

            Console.Write("Square: ");
            Console.WriteLine(rectangle.Square());

            Console.ReadKey();

            Console.WriteLine("Task-2 (HW - 2)"); // Task - 2

            Console.Write("Input left up X coordinate: ");
            InputUserData(out int leftUpX2, "Input left up X coordinate: ");

            Console.Write("Input left up Y coordinate: ");
            InputUserData(out int leftUpY2, "Input left up Y coordinate: ");
            Coordinate leftUpCoordinate2 = new Coordinate(leftUpX2, leftUpY2);

            Console.Write("Input rigt down X coordinate: ");
            InputUserData(out int rightDownX2, "Input rigt down X coordinate: ");

            Console.Write("Input right down Y coordinate: ");
            InputUserData(out int rightDownY2, "Input rigt down Y coordinate: ");

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
            InputUserData(out double radius, "Input radius: ");

            Console.Write("Square = ");
            Console.WriteLine(circle.Square(radius));

            Console.Write("Length = ");
            Console.WriteLine(circle.Length(radius));

            Console.ReadKey();

            Console.WriteLine("Task-4 (HW - 4)"); // Task - 4

            //Test static class Rectangle
            Console.Write("Input left up X coordinate: ");
            InputUserData(out int leftUpX4, "Input left up X coordinate: ");

            Console.Write("Input left up Y coordinate: ");
            InputUserData(out int leftUpY4, "Input left up Y coordinate: ");

            Coordinate leftUpCoordinate4 = new Coordinate(leftUpX4, leftUpY4);

            Console.Write("Input rigt down X coordinate: ");
            InputUserData(out int rightDownX4, "Input rigt down X coordinate: ");

            Console.Write("Input right down Y coordinate: ");
            InputUserData(out int rightDownY4, "Input rigt down Y coordinate: ");

            Coordinate rightDownCoordinate4 = new Coordinate(rightDownX4, rightDownY4);

            Console.Write("Perimetr: ");
            Console.WriteLine(StaticRectangle.Perimetr(leftUpCoordinate4, rightDownCoordinate4));

            Console.Write("Square: ");
            Console.WriteLine(StaticRectangle.Square(leftUpCoordinate4, rightDownCoordinate4));

            //Test static class Circle

            Console.Write("Input radius: ");
            InputUserData(out double radius4, "Input radius: ");

            Console.Write("Square = ");
            Console.WriteLine(StaticCircle.Square(radius4));

            Console.Write("Length = ");
            Console.WriteLine(StaticCircle.Length(radius4));

            Console.ReadKey();

            Console.WriteLine("Task-5 (HW - 5)"); // Task - 5

            Console.Write("Input real part: ");
            InputUserData(out double realFirst, "Input real part: ");

            Console.Write("Input imaginary part: ");
            InputUserData(out double imaginaryFirst, "Input imaginary part: ");

            ComplexNumber firstComplex = new ComplexNumber(realFirst, imaginaryFirst);

            Console.Write("Input real part: ");
            InputUserData(out double realSecond, "Input real part: ");

            Console.Write("Input imaginary part: ");
            InputUserData(out double imaginarySecond, "Input imaginary part: ");

            ComplexNumber secondComplex = new ComplexNumber(realSecond, imaginarySecond);

            ComplexNumber multiplyingResult = firstComplex * secondComplex;
            Console.WriteLine(multiplyingResult.ToString());

            ComplexNumber dividingResult = firstComplex / secondComplex;
            Console.WriteLine(dividingResult.ToString());

            Console.ReadKey();
        }

        public static void RunSecondHomeWork()
        {
            Console.WriteLine("-------------------- HomeWork 2 ---------------------------"); //HomeWork 2 

            Console.Write("Input X coordinate: ");
            InputUserData(out int x, "Input X coordinate: ");

            Console.Write("Input Y coordinate: ");
            InputUserData(out int y, "Input Y coordinate: ");

            Console.WriteLine("Task-1 (HW - 2)"); // Task - 1

            HomeWork_2.Rectangle rectangle1 = new HomeWork_2.Rectangle();
            rectangle1.Draw();

            Square square1 = new Square();
            square1.Draw();

            Console.ReadKey();

            Console.WriteLine("Task-2 (HW - 2)"); // Task - 2

            RectangleWithConstructor rectangle2 = new RectangleWithConstructor(x, y);
            rectangle2.Draw();

            SquareWithConstructor square2 = new SquareWithConstructor(x, y);
            square2.Draw();

            Console.ReadKey();

            Console.WriteLine("Task-3 (HW - 2)"); // Task - 3

            VirtualMethodBasedFigure figure3 = new VirtualMethodBasedFigure(x, y);
            figure3.Draw();

            VirtualMethodBasedRectangle rectangle3 = new VirtualMethodBasedRectangle(x, y);
            rectangle3.Draw();

            VirtualMethodBasedSquare square3 = new VirtualMethodBasedSquare(x, y);
            square3.Draw();

            Console.ReadKey();

            Console.WriteLine("Task-4 (HW - 2)"); // Task - 4

            InterfaceBasedFigure figure4 = new InterfaceBasedFigure(x, y);
            InterfaceBasedRectangle rectangle4 = new InterfaceBasedRectangle(x, y);
            InterfaceBasedSquare square4 = new InterfaceBasedSquare(x, y);

            DrawAll(figure4, rectangle4, square4);

            Console.ReadKey();
        }

        public static void RunThirdHomeWork()
        {
            Console.WriteLine("-------------------- HomeWork 3 ---------------------------"); //HomeWork 3

            PersonManager personManager = new PersonManager();

            Console.WriteLine("Task-1 (HW - 3)"); // Task - 1                  
            personManager.DisplayAgeAndName();

            Console.WriteLine("Task-2 (HW - 3)"); // Task - 2
            personManager.UseAddRangeMethodAndDisplay();

            Console.WriteLine("Task-3 (HW - 3)"); // Task - 3

            RandomDataManager randomDataManager = new RandomDataManager();
            randomDataManager.BeforeTransformation();
            randomDataManager.AfterTransformation();            

            Console.Write("Input page number: ");
            bool isSuccessfullParse = int.TryParse(Console.ReadLine(), out int page);
            if (!isSuccessfullParse)
            {
                return;
            }

            randomDataManager.DisplayPage(page);

            Console.ReadKey();
        }       

        public static void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            }
        }
    }
}
