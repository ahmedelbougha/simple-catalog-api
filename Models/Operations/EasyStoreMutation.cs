using System.Collections.Generic;
using aspnetcoregraphql.Data.Repositories;
using aspnetcoregraphql.Models.Entities;
using aspnetcoregraphql.Models.Types;
using GraphQL.Types;

namespace aspnetcoregraphql.Models.Operations
{
    public class EasyStoreMutation : ObjectGraphType
    {
        public EasyStoreMutation(IOrderRepository orders)
        {
            Name = "StoreMutation";
            Field<OrderType>(
                "createOrder",
                description: "create new order",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<OrderCreateInputType>> {Name = "order", Description = "order input"}
                ),
                resolve: context => {
                    var orderInput = context.GetArgument<OrderCreateInput>("order");
                    var id = orders.GetOrdersCount() + 1;
                    var order = new Order();

                    order.Id = id;
                    order.Name = orderInput.Name;
                    order.Description = orderInput.Description;
                    order.CustomerId = orderInput.CustomerId;

                    return orders.CreateAsync(order);
                }
            );  

            FieldAsync<OrderType>(
                "startOrder",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "orderId"}
                ),
                resolve: async context => {
                    var orderId = context.GetArgument<int>("orderId");
                    return await context.TryAsyncResolve(
                        async c => await orders.StartAsync(orderId)
                    );
                }
            );          
        }
    }
}