
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeModel;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> employees
        {
            get; set;
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True");
        //}
        //Data Source = (localdb)\MSSQLLocalDB;Integrated Security = True
    }
}
