using System.Linq;
using aspnetcoregraphql.Data.Repositories;
using aspnetcoregraphql.Models.Entities;
using GraphQL.Types;

namespace aspnetcoregraphql.Models.Types
{
    public class OrderCreateInputType : InputObjectGraphType
    {
        public OrderCreateInputType()
        {
            Name = "OrderInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("description");
            Field<NonNullGraphType<IntGraphType>>("customerId");
        }
    }
}