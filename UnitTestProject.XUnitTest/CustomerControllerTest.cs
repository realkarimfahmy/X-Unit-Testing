using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitProject.XUnitTest
{
    public class CustomerControllerTest
    {
        [Fact]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            Assert.IsType(new NotFound().GetType(), result);
        }
        [Fact]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);
            Assert.IsType(new Ok().GetType(), result);
        }
    }
}
