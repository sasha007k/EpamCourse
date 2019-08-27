using System;
using HomeWork_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHomeWork_1
{
    [TestClass]
    public class UnitTestHomeWork_1
    {
        [TestMethod]
        public void TestRectanglePerimetr()
        {            
            Coordinate leftUpCoordinate = new Coordinate(0, 3);
            Coordinate rightDownCoordinate = new Coordinate(3, 0);
            Rectangle rectangle = new Rectangle(leftUpCoordinate, rightDownCoordinate);
            double expected = 12;
            double actual = rectangle.Perimetr();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRectangleSquare()
        {
            Coordinate leftUpCoordinate = new Coordinate(0, 3);
            Coordinate rightDownCoordinate = new Coordinate(3, 0);
            Rectangle rectangle = new Rectangle(leftUpCoordinate, rightDownCoordinate);
            double expected = 9;
            double actual = rectangle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSircleSquare()
        {
            Circle circle = new Circle();
            double expected = 153.93804002591;
            double actual = circle.Square(7);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSircleLength()
        {
            Circle circle = new Circle();
            double expected = 43.98229715026;
            double actual = circle.Length(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            double expected = 5;
            double actual = MathHelper.SquareRoot(25);

            Assert.AreEqual(expected, actual);

            expected = 7;
            actual = MathHelper.SquareRoot(49);

            Assert.AreEqual(expected, actual);

            expected = 777;
            actual = MathHelper.SquareRoot(603729);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPropertyBasedRectangle()
        {            
            Coordinate leftUpCoordinate2 = new Coordinate(0, 7);
            Coordinate rightDownCoordinate2 = new Coordinate(7, 0);

            PropertyBasedRectangle rectangle2 = new PropertyBasedRectangle(leftUpCoordinate2, rightDownCoordinate2);

            double expected = 28;
            double actual = rectangle2.Perimetr;

            Assert.AreEqual(expected, actual);

            expected = 49;
            actual = rectangle2.Square;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStaticRectanglePerimetr()
        {
            Coordinate leftUpCoordinate = new Coordinate(0, 5);
            Coordinate rightDownCoordinate = new Coordinate(5, 0);
            double expected = 20;
            double actual = StaticRectangle.Perimetr(leftUpCoordinate, rightDownCoordinate);

            Assert.AreEqual(expected, actual);           
        }

        [TestMethod]
        public void TestStaticRectangleSquare()
        {
            Coordinate leftUpCoordinate = new Coordinate(0, 5);
            Coordinate rightDownCoordinate = new Coordinate(5, 0);
            double expected = 25;
            double actual = StaticRectangle.Square(leftUpCoordinate, rightDownCoordinate);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStaticSircleSquare()
        {
            double expected = 153.93804002591;
            double actual = StaticCircle.Square(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStaticSircleLength()
        {
            double expected = 43.98229715026;
            double actual = StaticCircle.Length(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyingComplexNumber()
        {
            ComplexNumber firstComplex = new ComplexNumber(5, 7);
            ComplexNumber secondComplex = new ComplexNumber(6, 8);

            ComplexNumber multiplyingResult = firstComplex * secondComplex;

            ComplexNumber expected = new ComplexNumber(30, 56); ;
            ComplexNumber actual = multiplyingResult;            

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void TestDividingComplexNumber()
        {
            ComplexNumber firstComplex = new ComplexNumber(5, 7);
            ComplexNumber secondComplex = new ComplexNumber(6, 8);

            ComplexNumber dividingResult = firstComplex / secondComplex;

            ComplexNumber expected = new ComplexNumber(0.833333333333333, 0.875); ;
            ComplexNumber actual = dividingResult;

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void TestToStringComplexNumber()
        {
            ComplexNumber complexNumber = new ComplexNumber(5, 7);


            string expected = "Real = 5   imaginary = 7";
            string actual = complexNumber.ToString();

            Assert.ReferenceEquals(expected, actual);
        }
    }
}
