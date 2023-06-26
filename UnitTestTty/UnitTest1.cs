
namespace homework10.tests

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPointToString()
        {
            //arrange
            Point testPoint = new Point(1, 0) ;
            string expected = "(1, 0)";
            //actual
            string actual = testPoint.ToString() ;  
            //assert
            Assert.AreEqual(expected, actual) ;
        }

        [TestMethod]
        public void TestPointDistance()
        {
            //arrange
            Point testPoint = new Point(1, 0);
            Point end = new Point(0, 1);
            double expected = Math.Sqrt(2);
            //actual
            double actual = testPoint.Distance(end);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestTrianglePerimeter()
        {
            //arrange
            Triangle testTriangle =new Triangle(new Point(0, 0), new Point(0, 3), new Point(4, 0));
            double expected = 12;
            //actual
            double actual = testTriangle.Perimeter();
            //assert
            Assert.AreEqual(expected, actual) ;
        }

        [TestMethod]

        public void TestTriangleArea()
        {
            Triangle testTriangle = new Triangle(new Point(-1, 0), new Point(1, 0), new Point(0, 3));
            double expected = 3;
            //actual
            double actual = Math.Round( testTriangle.Area(), 0);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestTriangleDistanceToOrigin() 
        {
            Triangle testTriangle = new Triangle(new Point(5, 0), new Point(0, 3), new Point(0, 0));
            double expected = 0;
            //actual
            double actual = testTriangle.DistanceToOrigin();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}