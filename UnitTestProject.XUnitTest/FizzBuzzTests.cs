using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitProject.XUnitTest
{
    public class FizzBuzzTests
    {
        [Fact]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);
            Assert.Equal("1", result);
        }
    }
}
