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
    }
}
