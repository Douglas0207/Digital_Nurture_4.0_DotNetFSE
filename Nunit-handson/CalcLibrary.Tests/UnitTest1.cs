using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [TestCase(5, 3, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -3, -5)]
        public void Add_WhenCalled_ReturnsSum(int a, int b, int expected)
        {
            int result = _calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TearDown]
        public void Cleanup()
        {
            _calc = null;
        }
    }
}
