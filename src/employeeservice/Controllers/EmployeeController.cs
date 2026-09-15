using employeeservice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace employeeservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Rahul Sharma",
                    Salary = 45000
                },
                new Employee
                {
                    Id = 2,
                    Name = "Amit Kumar",
                    Salary = 55000
                },
                 new Employee
                {
                    Id = 2,
                    Name = "Manisha",
                    Salary = 555000
                }
                ,
                 new Employee
                {
                    Id = 2,
                    Name = "Mahesh",
                    Salary = 975000
                }
            };

            return Ok(employees);
        }
    }
}
