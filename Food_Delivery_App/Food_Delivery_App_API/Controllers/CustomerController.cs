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
    }
}
