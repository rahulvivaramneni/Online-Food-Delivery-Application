using System;
using System.Collections.Generic;

#nullable disable

namespace Food_Delivery_App_API.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? RestarauntId { get; set; }
        public int? AgentId { get; set; }
        public int? UserId { get; set; }
        public string PaymentMode { get; set; }
        public int? Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }

        public virtual DeliveryAgent Agent { get; set; }
        public virtual Restaurant Restaraunt { get; set; }
        public virtual User User { get; set; }
    }
}
