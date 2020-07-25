using System;
using System.Collections.Generic;
using System.Text;

namespace UnitProject.Mocking
{
    public class OrderService
    {
        private readonly IStorage _storage;
        public OrderService(IStorage storage)
        {
            _storage = storage;
        }
        public int PlaceOrder(Order order)
        {
            int orderId = _storage.Store(order);

            return orderId;
        }

    }
    public class Order : IStorage
    {
        public int Store(Order order)
        {
            return 1 ;
        }
    }
    public interface IStorage
    {
       int Store(Order order);
    }
}
