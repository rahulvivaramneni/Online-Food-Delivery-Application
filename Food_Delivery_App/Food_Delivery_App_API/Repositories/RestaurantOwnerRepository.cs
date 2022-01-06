using Food_Delivery_App_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery_App_API.Repositories
{
    public class RestaurantOwnerRepository : IRestaurantOwnerRepository
    {
        OnlineFoodDeliveryContext db = null;
        public RestaurantOwnerRepository(OnlineFoodDeliveryContext db)
        {
            this.db = db;
        }
        public void AddAgentDetails(DeliveryAgent deliveryAgent)
        {
            throw new NotImplementedException();
        }

        public void AddItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public void UpdateAgentDetails(int agentId)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderStatus(int orderId)
        {
            throw new NotImplementedException();
        }

        public void UpdateRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public List<DeliveryAgent> ViewDeliveryAgentDetails(int restaurantId)
        {
            try
            {
                List<DeliveryAgent> deliveryAgents = db.DeliveryAgents.Where(i => i.RestarauntId == restaurantId).ToList();
                return deliveryAgents;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Item> ViewMenu(int restaurantId)
        {
            try
            {
                List<Item> items = db.Items.Where(i=>i.RestaurantId==restaurantId).ToList();
                return items;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> ViewOrderDetails(int restaurantId)
        {
            try
            {
                List<Order> orders = db.Orders.Where(i => i.RestaurantId == restaurantId).ToList();
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Restaurant ViewRestaurantDetails(int restaurantId)
        {
            try
            {
                Restaurant restaurant = db.Restaurants.Where(i=>i.RestaurantId==restaurantId).First();
                return restaurant;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
