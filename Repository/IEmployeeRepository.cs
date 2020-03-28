using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeModel;

namespace Repository
{
    public interface IEmployeeRepository
    {
        Task<int> AddEmployee(Employee employee);
        //Employee GetEmployee(int id);
        //IEnumerable<Employee> GetALLEmployee();       
        //Employee UpdateEmployee(Employee employeeChanges);
        //Employee DeleteEmployee(int id);
    }
}
