using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> OrdersAsync();
        Task<List<Order>> GetOrdersWithByCustomerIdAsync(int customerId);
        Task<Order> GetOrderAsync(int id);    
        Task<Order> CreateAsync(Order order);
        Task<Order> StartAsync(int orderId);
        int GetOrdersCount(); 
    }
}