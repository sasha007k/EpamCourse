using System;
using HomeWork_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHomeWork_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRectanglePerimetr()
        {            
            Coordinate leftUpCoordinate = new Coordinate(0, 3);
            Coordinate rightDownCoordinate = new Coordinate(3, 0);
            Rectangle rectangle = new Rectangle(leftUpCoordinate, rightDownCoordinate);
            var expected = 12;
            var actual = rectangle.Perimetr();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRectangleSquare()
        {
            Coordinate leftUpCoordinate = new Coordinate(0, 3);
            Coordinate rightDownCoordinate = new Coordinate(3, 0);
            Rectangle rectangle = new Rectangle(leftUpCoordinate, rightDownCoordinate);
            var expected = 9;
            var actual = rectangle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSircleSquare()
        {
            Circle circle = new Circle();
            var expected = 153.93804002591;
            var actual = circle.Square(7);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSircleLength()
        {
            Circle circle = new Circle();
            var expected = 43.98229715026;
            var actual = circle.Length(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            var expected = 5;
            var actual = MathHelper.SquareRoot(25);

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

            var expected = 28;
            var actual = rectangle2.Perimetr;

            Assert.AreEqual(expected, actual);

            expected = 49;
            actual = rectangle2.Square;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestComplexNumber()
        {
            ComplexNumber firstComplex = new ComplexNumber(5, 7);
            ComplexNumber secondComplex = new ComplexNumber(6, 8);

            ComplexNumber multiplyingResult = firstComplex * secondComplex;

            var expected = new ComplexNumber(30, 56); ;
            var actual = multiplyingResult;            

            Assert.ReferenceEquals(expected, actual);
        }
    }
}
