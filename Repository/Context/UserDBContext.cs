// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDBContext.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Janardan Das"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Repository.Context
{
    using System;
    using System.Collections.Generic;
    using EmployeeModel;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// This is a UserDBContext class which is interect with database
    /// It"s manage maintain database connection and used to retrive and save datafrom the database
    /// This class is inheritance DbContext which is a base class defined in the EF coreFreameWork
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserDBContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDBContext"/> class.
        /// This Carries the configuration information 
        /// </summary>
        /// <param name="options">The options.</param>
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the employees.
        /// This property is used to query and save instance of the Employee class
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public DbSet<Employee> employees
        {
            get; set;
        }
       
    }
}
