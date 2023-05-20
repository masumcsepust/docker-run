using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedAssembly;

namespace DockerBuild.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    public EmployeeController()
    {

    }
    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<Employee> employee = new List<Employee> {
            new Employee(1, "Masum Billah", "01684173432"),
            new Employee(1, "Dider Ullah", "01918993648"),
            new Employee(1, "Shoaib Ullah", "01918991234")
        };

        return Ok(employee);
    }
}
