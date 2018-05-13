using aspnetcoregraphql.Data.Repositories;
using aspnetcoregraphql.Models.Entities;
using GraphQL.Types;


namespace aspnetcoregraphql.Models.Types
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerRepository customerRepository)
        {
            Field(x => x.Id).Description("Order id.");
            Field(x => x.Name).Description("Order name.");
            Field(x => x.Description, nullable: true).Description("Order description.");
            Field(x => x.Created).Description("Order created date/time.");

            Field<CustomerType>(
                "customer", 
                resolve: context => customerRepository.GetCustomerAsync(context.Source.CustomerId).Result
             );
        }
    }
}