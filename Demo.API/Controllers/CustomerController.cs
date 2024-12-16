using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Domain;
using Demo.BL;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IService _service;
        public CustomerController(IService service) {
            _service = service;
        }

        [HttpGet]
        public CustomerLight GetLastCustomer(int id) 
        {
            var customer = _service.GetCustomer(id);
            return customer;
        }
    }
}
