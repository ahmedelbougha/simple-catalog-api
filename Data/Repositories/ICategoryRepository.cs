using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> CategoriesAsync();
        Task<Category> GetCategoryAsync(int id);
    }
}