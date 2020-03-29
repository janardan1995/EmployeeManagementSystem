// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EMployeeController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeModel;
    using Manager;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The controller design pattern class handels the incomming HTTP requests and response 
    /// to that user action
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly IEmployeeManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns></returns>
        [Route("GetALLEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetALLEmployee()
        {
            return this.manager.GetALLEmployee();
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("DeleteEmployee")]
        [HttpPost]
        public Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }


    }
}