using System;
using Xunit;


namespace UnitTest
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-1, 1, 0)]
        [InlineData(-5, -5, -10)]
        [InlineData(0, 0, 0)]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            int result = _calculator.Add(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(5, 5, 0)]
        [InlineData(-5, 3, -8)]
        [InlineData(3, -5, 8)]
        public void Sub_ShouldReturnCorrectDifference(int a, int b, int expected)
        {
            int result = _calculator.Sub(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(-5, 6, -30)]
        [InlineData(-7, -3, 21)]
        [InlineData(10, 0, 0)]
        public void Mul_ShouldReturnCorrectProduct(int a, int b, int expected)
        {
            int result = _calculator.Mul(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(-15, 5, -3)]
        [InlineData(0, 10, 0)]
        public void Div_ShouldReturnCorrectQuotient(int a, int b, int expected)
        {
            int result = _calculator.Div(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Div_ByZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(10, 0));
        }
    }
}

