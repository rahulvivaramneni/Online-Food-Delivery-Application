using System;
using System.Collections.Generic;

#nullable disable

namespace Food_Delivery_App_API.Entities
{
    public partial class DeliveryAgent
    {
        public DeliveryAgent()
        {
            Orders = new HashSet<Order>();
        }

        public int AgentId { get; set; }
        public int? RestarauntId { get; set; }
        public string AgentName { get; set; }
        public string AgentPhone { get; set; }

        public virtual Restaurant Restaraunt { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
