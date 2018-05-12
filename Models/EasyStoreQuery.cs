using System.Collections.Generic;
using aspnetcoregraphql.Data;
using aspnetcoregraphql.Models.Entities;
using aspnetcoregraphql.Models.Types;
using GraphQL.Types;

namespace aspnetcoregraphql.Models
{
    public class EasyStoreQuery : ObjectGraphType
    {
        public EasyStoreQuery(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            Field<CategoryType>(
                name: "category",
                description: "specific category data",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "id", Description = "Category id"}
                ),
                resolve: context => categoryRepository.GetCategoryAsync(context.GetArgument<int>("id")).Result
            );

            Field<ListGraphType<CategoryType>>(
                name: "categories",
                description: "list all categories",
                resolve: context => categoryRepository.CategoriesAsync().Result
            );

            Field<ProductType>(
                name: "product",
                description: "specific product data",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "id", Description = "Product id"}
                ),
                resolve: context => productRepository.GetProductAsync(context.GetArgument<int>("id")).Result
            );

            Field<ListGraphType<ProductType>>(
                name: "products",
                description: "list all products",
                resolve: context => productRepository.GetProductsAsync().Result
            );            
        }
    }
}