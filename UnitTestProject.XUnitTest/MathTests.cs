using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace UnitProject.XUnitTest
{
    public class MathTests
    {
        private Math _math;
        public MathTests()
        {
            _math = new Math();
        }
        // permaterized test
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(1, 2, 2)]
        [InlineData(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a , int b , int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.Equal(result , expectedResult);
        }

        [Fact]
        //[Fact(Skip = "reason")] ignoring
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
           var result =  _math.Add(1, 2);
           Assert.Equal(3, result);
        }
        [Fact]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            Assert.NotEmpty(result);
            Assert.Equal(new[] { 1,3,5}, result);
        }
        //[Fact]
        //public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        //{
        //    var result = _math.Max(2,1);
        //    Assert.Equal(2,result);
        //}

        //[Fact]
        //public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        //{
        //    var result = _math.Max(1,2);
        //    Assert.Equal(2, result);
        //}
        //[Fact]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        //{
        //    var result = _math.Max(2, 2);
        //    Assert.Equal(2, result);
        //}
    }
}
