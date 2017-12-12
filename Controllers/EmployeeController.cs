using System;
using System.Threading.Tasks;
using AspNetAuthentication.Models;
using AspNetAuthentication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetAuthentication.Controllers {

    [Route ("api/employees")]
    public class EmployeeController : Controller {
        private readonly IEmployee _repository;

        public EmployeeController (IEmployee repository) {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees () {
            var getEmployees = await _repository.EmployeesAsync ();
            return Ok (getEmployees);
        }

        [HttpGet ("{employeeId}", Name = "GetEmployee")]
        public async Task<IActionResult> GetEmployees (Guid employeeId) {
            var getEmployee = await _repository.EmployeeAsync (employeeId);
            return Ok (getEmployee);
        }

    }
}