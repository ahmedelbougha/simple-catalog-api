using System.Collections.Generic;

namespace aspnetcoregraphql.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Product> Products { get; set; }
    }
}