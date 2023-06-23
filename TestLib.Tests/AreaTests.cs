using TestLib;

namespace TestLib.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void CircleAreaTest_1()
        {
            Circle circle = new Circle(5);

            Assert.AreEqual(78.539816, Math.Round(circle.Area(), 6, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void TriangleAreaTest_1()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.Area());
        }

        [TestMethod]
        public void TriangleAreaTest_2()
        {
            Triangle triangle = new Triangle(22, 120, 140);

            Assert.AreEqual(593.598349, Math.Round(triangle.Area(), 6, MidpointRounding.AwayFromZero));
        }
    }
}
