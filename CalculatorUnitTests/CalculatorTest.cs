using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;

namespace CalculatorUnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(0, 2, 2)]
        [DataRow(2, 7, 9)]
        [DataRow(10, 3, 13)]
        [DataRow(7, 15, 22)]
        public void CalculatorAddMethodMustAdd(double left, double right, double expected)
        {
            double result;
            result = Calculator.Add(left, right);
            Assert.AreEqual(expected, result);
        }
    }
}
