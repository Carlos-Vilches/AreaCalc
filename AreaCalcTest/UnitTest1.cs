using areaCalc;
namespace AreaCalcTest
{
    [TestClass]
    public class AreaCalcTests
    {
        [TestMethod]
        public void SquareTest()
        {
            int baseNum = 2, result;
            result = AreaCalc.Calc(baseNum);
            Assert.AreEqual(4, result);
        }
        [TestMethod] 
        public void RectangleTest()
        {
            int baseNum = 2, height = 4, result;
            result = AreaCalc.Calc(baseNum, height);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void CircleTets()
        {
            int radius = 5;
            float result;
            result = AreaCalc.Calc(radius, Math.PI);
            Assert.AreEqual(result, 78.53982f);
        }
        [TestMethod]
        public void PentagonTets()
        {
            int baseNum = 4;
            float apothem = 2, result;
            result = AreaCalc.Calc(baseNum, apothem);
            Assert.AreEqual(result, 20);
        }
    }
}