using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void Task_Add_TwoNumber()
        {
            // Arrange
            var num1 = 11.9;
            var num2 = 20.1;
            var expectedValue = 32;
            // Act

            var sum = PrimeService.Add(num1, num2);
            // Assert
            Assert.Equal(expectedValue, sum, 1); // 1 is a precision which asserts that values are equal within 1 decimal place, it may vary
        }
        [Fact]
        public void Task_Subtract_TwoNumbers()
        {
            // Arrange
            var num1 = 20.1;
            var num2 = 10.1;
            var actualValue = 10.0;
            // Act
            var subtract = PrimeService.Subtract(num1, num2);
            // Assert
            Assert.Equal(actualValue, subtract, 1);
        }
        [Fact]
        public void Task_Multiply_TwoNumbers()
        {
            // Arrange
            var num1 = 10.0;
            var num2 = 10.0;
            var actualValue = 100.0;
            // Act
            var multiply = PrimeService.Multiply(num1, num2);
            // Assert
            Assert.Equal(actualValue, multiply, 1);
        }
        [Fact]
        public void Task_Divide_TwoNumbers()
        {
            // Arrange
            var num1 = 20.0;
            var num2 = 10.0;
            var actualValue = 2.0;
            // Act
            var division = PrimeService.Divide(num1, num2);

            // Assert
            Assert.Equal(actualValue, division, 1);
        }
    }
}