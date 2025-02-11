using SimpleCalculatorApp;

namespace CalculatorUnitTest
{
    public class Tests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [Test]
        public void AddNum_PositiveNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Add(5, 10);

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void AddNum_NegativeNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Add(-10, -15);

            Assert.That(result, Is.EqualTo(-25));
        }

        [Test]
        public void SubractNum_PositiveNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Subtract(10, 15);

            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void SubtractNum_NegativeNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Subtract(-15, -8);

            Assert.That(result, Is.EqualTo(-7));
        }

        [Test]
        public void MultiplyNum_PositiveNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Multiply(5, 4);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void MultiplyNum_Zero_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Multiply(10, 0);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void DivideNum_PositiveNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Divide(30, 6);

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DivideNum_NegativeNum_True()
        {
            var calculator = new SimpleCalculator();

            double result = calculator.Divide(-20, -5);

            Assert.That(result, Is.EqualTo(4));
        }

    }
}