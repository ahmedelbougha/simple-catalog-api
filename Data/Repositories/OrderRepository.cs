using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order>{
                new Order()
                {
                    Id = 1,
                    CustomerId = 3,
                    Name = "Order 1",
                    Description = "some order description 1"
                },
                new Order()
                {
                    Id = 1,
                    CustomerId = 2,
                    Name = "Order 2",
                    Description = "some order description 2"
                },
                new Order()
                {
                    Id = 3,
                    CustomerId = 1,
                    Name = "Order 3",
                    Description = "some order description 3"
                },
                new Order()
                {
                    Id = 4,
                    CustomerId = 2,
                    Name = "Order 1",
                    Description = "some order description 4"
                },
                new Order()
                {
                    Id = 5,
                    CustomerId = 2,
                    Name = "Order 3",
                    Description = "some order description 5"
                }
            };
        }

        public Task<Order> GetOrderAsync(int id)
        {
            return Task.FromResult(_orders.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Order>> OrdersAsync()
        {
            return Task.FromResult(_orders);
        }
       
        public Task<List<Order>> GetOrdersWithByCustomerIdAsync(int customerId)
        {
            return Task.FromResult(_orders.Where(x => x.CustomerId == customerId).ToList());
        }

        public Task<Order> CreateAsync(Order order) 
        {
            _orders.Add(order);
            return Task.FromResult(order);
        }
        public Task<Order> StartAsync(int orderId)
        {
            var order = GetById(orderId);
            order.Start();
            return Task.FromResult(order);
        }

        public int GetOrdersCount()
        {
            return _orders.Count();
        }

        private Order GetById(int orderId) 
        {
            var order = _orders.FirstOrDefault(x => x.Id == orderId);
            if (order == null) 
            {
                throw new ArgumentException("Invalid Order ID");
            }

            return order;
        }
    }
}