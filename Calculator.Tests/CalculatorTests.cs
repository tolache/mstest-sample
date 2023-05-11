using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        public TestContext TestContext { get; set; }

        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }
        
        [TestMethod]
        public void Add_1and2_Return3()
        {
            int result = _calculator.Add(1, 2);
            TestContext.WriteLine("This is my test output from test Add_1and2_Return3.");
            Assert.AreEqual(result, 3);
        }
    }
}
