using Food_Delivery_App_API.Entities;
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

        public List<Order> OrderStatus(int UserId)
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Restaurant SearchRestarauntByName(string ResturantName)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerDetails(User user)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<Order> ViewOrdersOfCustomer(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
