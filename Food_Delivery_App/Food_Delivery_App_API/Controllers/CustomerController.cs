using Food_Delivery_App_API.Entities;
using Food_Delivery_App_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery_App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerController(ICustomerRepository repository)
        {
            this.customerRepository = repository;
        }
        [HttpGet]
        [Route("ViewAllRestaraunts")]
        public IActionResult GetAllRestaraunts()
        {
            try
            {
                List<Restaurant> customers = customerRepository.ViewAllRestaraunts();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStatus/{id}")]
        public IActionResult GetStatus(int id)
        {
            try
            {
                List<Order> orders = customerRepository.OrderStatus(id);
                return Ok(orders);

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("SearchRestarauntByName/{restaurantName}")]
        public IActionResult SearchRestarauntByName(string restaurantName)
        {
            try
            {
                Restaurant restaurant = customerRepository.SearchRestarauntByName(restaurantName);
                return Ok(restaurant);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("ViewAllRestarauntsByCity​​​​​​​​")]
        public IActionResult ViewAllRestarauntsByCity(string City)
        {
            try
            {
                List<Restaurant> restaurants = customerRepository.ViewAllRestarauntsByCity(City);
                return Ok(restaurants);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer(User user)
        {
            try
            {
                customerRepository.UpdateCustomerDetails(user);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("ViewOrdersOfCustomer")]
        public IActionResult ViewOrdersOfCustomer(int UserId)
        {
            try
            {
                List<Order> orders = customerRepository.ViewOrdersOfCustomer(UserId);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
