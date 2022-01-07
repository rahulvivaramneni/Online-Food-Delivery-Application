﻿using Food_Delivery_App_API.Entities;
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
            try
            {
                db.DeliveryAgents.Add(deliveryAgent);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteItem(long itemId)
        {
            try
            {
                Item item = db.Items.Find(itemId);
                db.Items.Remove(item);
                db.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddItem(Item item)
        {
            try
            {
                using (OnlineFoodDeliveryContext db = new OnlineFoodDeliveryContext())
                {
                    db.Items.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            try
            {
                db.Restaurants.Add(restaurant);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateAgentDetails(DeliveryAgent deliveryAgent)
        {
            try
            {
                
                db.DeliveryAgents.Update(deliveryAgent);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateItem(Item item)
        {
            try
            {
                
                db.Items.Update(item);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateOrderStatus(long orderId, string orderStatus)
        {
            Order order = db.Orders.Find(orderId);
            order.OrderStatus = orderStatus;
            db.SaveChanges();
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            try
            {
                db.Restaurants.Update(restaurant);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DeliveryAgent> ViewDeliveryAgentDetails(long restaurantId)
        {
            try
            {
                List<DeliveryAgent> deliveryAgents = db.DeliveryAgents.Where(i => i.RestaurantId == restaurantId).ToList();
                return deliveryAgents;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Item> ViewMenu(long restaurantId)
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

        public List<Order> ViewOrderDetails(long restaurantId)
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

        public Restaurant ViewRestaurantDetails(long restaurantId)
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
