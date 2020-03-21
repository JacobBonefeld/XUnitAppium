using System;
using WindowsProgramsTesting;
using Xunit;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10,5,2,2,1)]
        [InlineData(27,9,9,9)]
        public void AddNumbersTest(int expectedVal, params int[] numbers)
        {
            Calculator cal = new Calculator();

            int actualVal = cal.addNumbers(numbers);

            Assert.Equal(expectedVal, actualVal);

        }

        [Theory]
        [InlineData(-1,2,3)]
        [InlineData(10,2,3)]
        public void AddNumbersInvalidInput(params int[] numbers)
        {
            Calculator cal = new Calculator();

            Assert.Throws<ArgumentException>(() => cal.addNumbers(numbers));
        }
    }
}
