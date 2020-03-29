﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository
{    
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using EmployeeModel;

    /// <summary>
    /// This is a interface class of the repository
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>int</returns>
        Task<int> AddEmployee(Employee employee);

        //Employee GetEmployee(int id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>IEnuberable</returns>
        IEnumerable<Employee> GetALLEmployee();

        //Employee UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Object</returns>
        Employee DeleteEmployee(int id);
    }
}
