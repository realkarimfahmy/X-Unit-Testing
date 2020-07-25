using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitProject.Mocking;
using Xunit;

namespace UnitProject.XUnitTest.Mocking
{
    public class OrderServiceTests
    {
        [Fact]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);
            var order = new Order();
            service.PlaceOrder(order);
            storage.Verify(s => s.Store(order));
        }
    }
}
