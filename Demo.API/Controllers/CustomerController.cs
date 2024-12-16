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



        [HttpPost("save")]
        public IActionResult SaveComment(string comment)
        {
            // Code vulnérable : Sauvegarde la donnée sans validation
            System.IO.File.WriteAllText("comments.txt", comment);
            return Ok("Comment saved!");
        }
    }
}
