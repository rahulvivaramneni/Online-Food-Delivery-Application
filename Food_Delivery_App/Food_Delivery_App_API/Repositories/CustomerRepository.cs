﻿using Food_Delivery_App_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery_App_API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        OnlineFoodDeliveryContext db = null;
        public CustomerRepository(OnlineFoodDeliveryContext db)
        {
            this.db = db;
        }

        public void CancelOrder(int OrderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> OrderStatus(int userId)
        {
            try
            {
                List<Order> order = new List<Order>();
                order = db.Orders.Where(u => u.UserId == userId).ToList();

                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Restaurant SearchRestarauntByName(string ResturantName)
        {
            try
            {
                Restaurant restaurant = db.Restaurants.Where(i => i.RestaurantName == ResturantName).FirstOrDefault<Restaurant>();
                return restaurant;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateCustomerDetails(User user)
        {
            try
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Restaurant> ViewAllRestaraunts()
        {
            try
            {
                List<Restaurant> restaurants = db.Restaurants.ToList();
                return restaurants;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Restaurant> ViewAllRestarauntsByCity(string City)
        {

            try
            {
                List<Restaurant> restaurants = db.Restaurants.Where(i => i.City == City).ToList();
                return restaurants;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Order> ViewOrdersOfCustomer(int UserId)
        {
            try
            {
                List<Order> orders = db.Orders.Where(i => i.UserId == UserId).ToList();
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
