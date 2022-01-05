using Food_Delivery_App_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Food_Delivery_App_API.Repositories
{
   public interface ICustomerRepository
    {
        List<Restaurant> ViewAllRestaraunts();
        List<Restaurant> ViewAllRestarauntsByCity(string City);
        Restaurant SearchRestarauntByName(string ResturantName);
        void PlaceOrder(Order order);
        void CancelOrder(int OrderId);
        List<Order> ViewOrdersOfCustomer(int UserId);
        List<Order> OrderStatus(int UserId);
        void updateCustomerDetails(User user);
        //Logout Function
    }
}
