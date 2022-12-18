namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestDividedByZeroExceptoin()
        {
           Assert.ThrowsException<DivideByZeroException>(() => CalculatorLogic.Calculator.Division(2, 0));
        }
    }
}