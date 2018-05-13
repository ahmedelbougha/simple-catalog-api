using System.Linq;
using aspnetcoregraphql.Data.Repositories;
using aspnetcoregraphql.Models.Entities;
using GraphQL.Types;

namespace aspnetcoregraphql.Models.Types
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType(IOrderRepository orderRepository)
        {
            Field(x => x.Id).Description("Customer id.");
            Field(x => x.Name, nullable: true).Description("Customer name.");

            Field<ListGraphType<OrderType>>(
                "orders", 
                resolve: context => orderRepository.GetOrdersWithByCustomerIdAsync(context.Source.Id).Result.ToList()
            );
        }
    }
}