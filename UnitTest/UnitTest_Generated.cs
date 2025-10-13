
using System;
using Xunit;

namespace CalculatorTests
{
    /// <summary>
    /// Unit tests for the <see cref="Calculator"/> class.
    /// </summary>
    public class CalculatorUnitTests
    {
        private readonly Calculator _calc = new Calculator();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-5, 7, 2)]
        [InlineData(int.MaxValue, 0, int.MaxValue)]
        public void Add_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Act
            var result = _calc.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-10, -5, -5)]
        [InlineData(int.MinValue, 1, int.MinValue + 1)]
        public void Sub_ReturnsCorrectDifference(int a, int b, int expected)
        {
            // Act
            var result = _calc.Sub(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(-3, 6, -18)]
        [InlineData(int.MaxValue / 2, 2, int.MaxValue)]   // avoid overflow in test data
        public void Mul_ReturnsCorrectProduct(int a, int b, int expected)
        {
            // Act
            var result = _calc.Mul(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(-9, -3, 3)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        public void Div_ReturnsCorrectQuotient(int a, int b, int expected)
        {
            // Act
            var result = _calc.Div(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
        //[Fact]
        //public void Div_ByZero_ThrowsDivideByZero