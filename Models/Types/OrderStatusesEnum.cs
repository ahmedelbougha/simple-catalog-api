using aspnetcoregraphql.Data.Repositories;
using aspnetcoregraphql.Models.Entities;
using GraphQL.Types;

namespace aspnetcoregraphql.Models.Types
{
    public class OrderStatusesEnum : EnumerationGraphType
    {
        public OrderStatusesEnum()
        {
            Name = "OrderStatuses";
            AddValue("CREATED", "Order was created", Order.OrderStatuses.CREATED);
            AddValue("PROCESSING", "Order is processing", Order.OrderStatuses.PROCESSING);
            AddValue("COMPLETED", "Order was completed", Order.OrderStatuses.COMPLETED);
            AddValue("CANCELLED", "Order was cancelled", Order.OrderStatuses.CANCELLED);
            AddValue("CLOSED", "Order was closed", Order.OrderStatuses.CLOSED);
        }
    }
}