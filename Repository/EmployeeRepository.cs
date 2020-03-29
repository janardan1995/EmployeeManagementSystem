using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeModel;
using Repository.Context;

namespace Repository
{
    public class ImpRepo : IEmployeeRepository
    {
        private readonly UserDBContext userDBContext;
        public ImpRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public Task<int> AddEmployee(Employee employee)
        {
            userDBContext.employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

        //public Employee DeleteEmployee(int id)
        //{
        //    Employee employee = userDBContext.employees.Find(id);
        //    if (employee!=null)
        //    {
        //        userDBContext.employees.Remove(employee);
        //        userDBContext.SaveChanges();
        //    }
        //    return employee;
        //}

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
