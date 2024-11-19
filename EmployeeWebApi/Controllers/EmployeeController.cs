using EmployeeWebApi.Exceptions;
using EmployeeWebApi.Models;
using EmployeeWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        //It gives all the available employees
        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = _service.GetEmployees();
            return Ok(employees);
        }

        //It give the employee details using employee id
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var employee = _service.GetEmployee(id);
            return Ok(employee);
        }

        //It add the new employee in database
        [HttpPost] 
        public IActionResult AddEmployee(Employee employee) 
        { 
            if (!ModelState.IsValid) 
            { 
                var errors = String.Join(";", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)); 
                throw new ValidationException($"{errors}" ); 
            }
            _service.Add(employee); 
            return Ok(employee.Id); }
    }
            
}
