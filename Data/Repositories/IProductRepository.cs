using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> GetProductsWithByCategoryIdAsync(int categoryId);
        Task<Product> GetProductAsync(int id);
    }
}