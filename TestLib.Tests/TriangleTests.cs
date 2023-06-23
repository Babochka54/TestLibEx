using TestLib;

namespace TestLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IncorrectTriangleTest()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(6, 2, 2));
        }

        [TestMethod]
        public void IsRightTriangleTest_1()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(true ,triangle.isRightTriangle());
        }

        [TestMethod]
        public void IsRightTriangleTest_2()
        {
            Triangle triangle = new Triangle(4, 4, 5);

            Assert.AreEqual(false, triangle.isRightTriangle());
        }
    }
}