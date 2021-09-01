using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Calculator _calculator;
        
        public CalculatorTests()
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
