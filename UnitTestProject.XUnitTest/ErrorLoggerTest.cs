using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitProject.XUnitTest
{
    public class ErrorLoggerTest
    {
        [Fact]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            string logMesage = "Last Log";
            logger.Log(logMesage);
            Assert.Equal(logger.LastError, logMesage);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            Assert.Throws<ArgumentNullException>(() => logger.Log(error));
        }

        [Fact]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender , args) => { id = args; };
            logger.Log("a");
            Assert.NotEqual(id, Guid.Empty);
           
        }
    }
}
