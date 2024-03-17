using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Entity;
using Repository.Interface;

namespace DapperASPNETcore.Controllers
{
    [Route("api/tejas")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBL _employeedl;

        public EmployeeController(IEmployeeBL employeedl)
        {
            this._employeedl = employeedl;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeList()
        {
            try
            {
                var employee = await _employeedl.GetEmployees();
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                var employee = await _employeedl.GetEmployeeById(id);
                if (employee == null)
                {
                    return NotFound("Employee not found");
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }

}
