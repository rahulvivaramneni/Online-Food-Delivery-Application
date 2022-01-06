using Food_Delivery_App_API.Entities;
using Food_Delivery_App_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery_App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantOwnerController : ControllerBase
    {
        private readonly IRestaurantOwnerRepository restaurantOwnerRepository;
        public RestaurantOwnerController(IRestaurantOwnerRepository repository)
        {
            this.restaurantOwnerRepository = repository;
        }
        [HttpGet]
        [Route("ViewDeliveryAgentDetails")]
        public IActionResult ViewDeliveryAgentDetails(int restaurantId)
        {
            try
            {
                List<DeliveryAgent> deliveryAgents = restaurantOwnerRepository.ViewDeliveryAgentDetails(restaurantId);
                return Ok(deliveryAgents);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("ViewMenu")]
        public IActionResult ViewMenu(int restaurantId)
        {
            try
            {
                List<Item> items = restaurantOwnerRepository.ViewMenu(restaurantId);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("ViewOrderDetails")]
        public IActionResult ViewOrderDetails(int restaurantId)
        {
            try
            {
                List<Order> orders = restaurantOwnerRepository.ViewOrderDetails(restaurantId);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("ViewRestaurantDetails")]
        public IActionResult ViewRestaurantDetails(int restaurantId)
        {
            try
            {
                Restaurant restaurant = restaurantOwnerRepository.ViewRestaurantDetails(restaurantId);
                return Ok(restaurant);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddAgentDetails")]
        public IActionResult AddAgentDetails(DeliveryAgent deliveryAgent)
        {
            try
            {
                restaurantOwnerRepository.AddAgentDetails(deliveryAgent);
                return Ok();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateAgentDetails")]
        public IActionResult UpdateAgentDetails(DeliveryAgent deliveryAgent)
        {
            try
            {
                restaurantOwnerRepository.UpdateAgentDetails(deliveryAgent);
                return Ok();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateRestaurant")]
        public IActionResult PutUpdateRestaurant(Restaurant restaurant)
        {
            try
            {
                restaurantOwnerRepository.UpdateRestaurant(restaurant);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult PutUpdateItem(Item item)
        {
            try
            {
                restaurantOwnerRepository.UpdateItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddLead(Item item)
        {
            try
            {
                restaurantOwnerRepository.AddItem(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteItem/{itemId}")]
        public IActionResult DeleteItem(int itemId)
        {
            try
            {
                restaurantOwnerRepository.DeleteItem(itemId);
                return Ok("Item Deleted Successfully");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
