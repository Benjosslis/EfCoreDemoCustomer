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



        private readonly string _connectionString = "Server=localhost;Database=DemoDb;Trusted_Connection=True;";

        [HttpGet("search")]
        public IActionResult Search(string searchTerm)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = $"SELECT * FROM Users WHERE Username LIKE '%{searchTerm}%'";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        var reader = command.ExecuteReader();
                        var results = new List<string>();
                        while (reader.Read())
                        {
                            results.Add(reader["Username"].ToString());
                        }
                        return Ok(results);
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    
    }
}
