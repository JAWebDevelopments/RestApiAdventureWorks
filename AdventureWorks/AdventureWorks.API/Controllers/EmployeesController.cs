using AdventureWorks.API.Dtos;
using AdventureWorks.Domain.Models;
using AdventureWorks.Domain.Repository;
using AdventureWorks.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventureWorks.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet(Name = "Employees")]
        public IActionResult Get(int EmployeeId)
        {
            Employee result = new();
            result = _employeeService.GetEmployee(EmployeeId);
            string jsonString = JsonConvert.SerializeObject(result);
            if (result!=null)
            {
                return Content(jsonString, "application/json");
            }
            else
            {
                return NotFound("No se ha encontrado");
            }


        }
    }
}
