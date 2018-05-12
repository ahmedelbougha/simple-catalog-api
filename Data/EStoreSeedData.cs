using aspnetcoregraphql.Models;
using aspnetcoregraphql.Models.Entities;
using System.Linq;

namespace aspnetcoregraphql.Data.Seed
{
    public static class EStoreSeedData
    {
        public static void EnsureSeedData(this MainDBContext db)
        {
            if (!db.Products.Any())
            {
                var product = new Product
                {
                    Name = "R2-D2"
                };
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        private static Product GetRandomProductData() 
        {
            var product = new Product
            {
                CategoryId = 2,
                Name = "Huawei GR5",
                Description = "3.3GHZ 3GB RAM",
                Price = 4000
            };

            return product;
        }
    }
}