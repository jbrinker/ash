using ASH.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASH.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           
        }

        [HttpPost]
        public HttpResponseMessage AddEmployee(Employee employee) 
        {
            return Ok();
        }
    }
}
