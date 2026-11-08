namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private readonly Lab_1_Calculator.Calculator _calculator = new Lab_1_Calculator.Calculator();

        [TestMethod]
        public void TestAddition()
        {
            double result = _calculator.EvaluateExpression("2 + 3");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double result = _calculator.EvaluateExpression("5 - 3");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double result = _calculator.EvaluateExpression("4 * 3");
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            double result = _calculator.EvaluateExpression("10 / 2");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            _calculator.EvaluateExpression("10 / 0");
        }

        [TestMethod]
        public void TestOrderOfOperations()
        {
            double result = _calculator.EvaluateExpression("2 + 3 * 4");
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void TestComplexExpression()
        {
            double result = _calculator.EvaluateExpression("5 + 6 * 2 - 3 / 1");
            Assert.AreEqual(14, result);
        }
    }
}
