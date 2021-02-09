using NUnit.Framework;
using GeometryTestTask;
using System;

namespace GeometryTests
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleDoesntExist()
        {
            Assert.Throws<Exception>(() => new Triangle(2, 1, 4));
        }

        [Test]
        public void TriangleOutOfRangeArgumentException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }
        [Test]
        public void RoundOutOfRangeArgumentException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Round(-1));           
        }
        [Test]
        public void RightAngledTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.isRightAngled());
            triangle = new Triangle(5, 5, 10);
            Assert.IsFalse(triangle.isRightAngled());
        }
        [Test]
        public void TriangleSquareAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area);
            triangle = new Triangle(5, 5, 8);
            Assert.AreEqual(12, triangle.Area);
        }
        [Test]
        public void RoundAreaTest()
        {
            var round = new Round(1);
            Assert.AreEqual(Math.PI, round.Area);
           ;
        }
    }
}