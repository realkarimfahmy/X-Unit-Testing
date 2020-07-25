using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitProject.XUnitTest
{
    public class DemeritPointsCalculatorTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }
       
        [Theory]
        [InlineData(0, 0)]
        [InlineData(64, 0)]
        [InlineData(65, 0)]
        [InlineData(66, 0)]
        [InlineData(70, 1)]
        [InlineData(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed , int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();
            var points = calculator.CalculateDemeritPoints(speed);
            Assert.Equal(points, expectedResult);
        }
    }
}
