using Food_Delivery_App_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery_App_API.Repositories
{
    public interface IRestaurantOwnerRepository
    {
        void AddRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void AddItem(Item item);
        public void DeleteItem(int itemId);
        void UpdateItem(Item item);
        void AddAgentDetails(DeliveryAgent deliveryAgent);
        void UpdateAgentDetails(DeliveryAgent deliveryAgent);
        List<Item> ViewMenu(int restaurantId);// Owner can able to all the items in the menu        
        Restaurant ViewRestaurantDetails(int restaurantId);
        List<DeliveryAgent> ViewDeliveryAgentDetails(int restaurantId);
        List<Order> ViewOrderDetails(int restaurantId);
        void UpdateOrderStatus(int orderId,string orderStatus);
    }
}
