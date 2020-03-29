// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="Bridgelabz">
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
    using Repository.Context;

    /// <summary>
    /// This is Repository class where InterfaceRepository parts are implemented.
    /// </summary>
    /// <seealso cref="Repository.IEmployeeRepository" />
    public class ImpRepo : IEmployeeRepository
    {
        /// <summary>
        /// The user database context
        /// </summary>
        private readonly UserDBContext userDBContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImpRepo"/> class.
        /// </summary>
        /// <param name="userDBContext">The user database context.</param>
        public ImpRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// int
        /// </returns>
        public Task<int> AddEmployee(Employee employee)
        {
            userDBContext.employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Object
        /// </returns>
        public Employee DeleteEmployee(int id)
        {
            Employee employee = userDBContext.employees.Find(id);
            if (employee != null)
            {
                userDBContext.employees.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;
        }

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>
        /// IEnuberable
        /// </returns>
        public IEnumerable<Employee> GetALLEmployee()
        {
            return userDBContext.employees;
        }

        //public Employee GetEmployee(int id)
        //{
        //    return userDBContext.employees.Find(id);
        //}

        //public Employee UpdateEmployee(Employee employeeChanges)
        //{
        //    var employee = userDBContext.employees.Attach(employeeChanges);
        //    employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    userDBContext.SaveChanges();
        //    return employeeChanges;
        //}
    }
}
