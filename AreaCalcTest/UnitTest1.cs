using areaCalc;
namespace AreaCalcTest
{
    [TestClass]
    public class AreaCalcTests
    {
        [TestMethod]
        public void SquareTest()
        {
            int num = 2, result;
            result = AreaCalc.Calc(num)
            Assert.AreEqual(4, result);
        }
    }
}