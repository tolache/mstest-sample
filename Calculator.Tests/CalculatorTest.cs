using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly Calculator _calculator;
        
        public CalculatorTest()
        {
            _calculator = new Calculator();
        }
        
        [TestMethod]
        public void Add_1and2_Return3()
        {
            int result = _calculator.Add(1, 2);
            Assert.AreEqual(result, 3);
        }
    }
}
