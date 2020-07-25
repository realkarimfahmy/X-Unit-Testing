using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitProject.XUnitTest
{
    public class HTMLFormatterTest
    {
        [Fact]
        // Test Strings
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HTMLFormatter();
            var result = formatter.FormatAsBold("abc");
            // Too Specific
            Assert.Equal("<strong>abc</strong>", result.ToLower());
            //More general 
            Assert.StartsWith("<strong>", result.ToLower());
            Assert.EndsWith("</strong>", result.ToLower());
            Assert.Contains("abc", result.ToLower());
        }
    }
}
