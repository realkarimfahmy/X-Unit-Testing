using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitProject.Mocking;
using Xunit;

namespace UnitProject.XUnitTest.Mocking
{
    public class VideoServiceTest
    {
        [Fact]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var service = new VideoService(fileReader.Object);
            var result = service.ReadVideoTitle();
            Assert.Contains("Error", result);
        }
    }
}
