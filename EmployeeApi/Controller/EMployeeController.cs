using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeModel;
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }

        }

        [Route("GetALLEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetALLEmployee()
        {
            return this.manager.GetALLEmployee();
        }
    }
}