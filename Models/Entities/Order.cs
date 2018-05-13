using System;
using System.Collections.Generic;
using System.Text;


namespace aspnetcoregraphql.Models.Entities
{
    public class Order
    {
        public Order()
        {
            Status = OrderStatuses.CREATED;
            Created = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public OrderStatuses Status { get; private set; }
        public int CustomerId { get; set; }

        Customer Customer { get; set;}

        public void Start() 
        {
            Status = OrderStatuses.PROCESSING;
        }

        [Flags]
        public enum OrderStatuses 
        {
            CREATED = 2,
            PROCESSING = 4, 
            COMPLETED = 8,
            CANCELLED = 16,
            CLOSED = 32
        }
    }
}