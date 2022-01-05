using System;
using System.Collections.Generic;

#nullable disable

namespace Food_Delivery_App_API.Entities
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public int? RestaurantId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string ItemDescription { get; set; }
        public bool? IsAvailable { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
