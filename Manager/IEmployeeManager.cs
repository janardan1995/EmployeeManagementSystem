﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Manager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using EmployeeModel;

    /// <summary>
    /// This is an interface of Manager class
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        Task<int> AddEmployee(Employee employee);

        //Employee GetEmployee(int id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetALLEmployee();

        //Employee UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Employee DeleteEmployee(int id);
    }
}
