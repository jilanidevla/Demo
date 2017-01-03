using Cassandra_Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassandra_Employee
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> getEmployee();
        Task<IEnumerable<Employee>> EditEmployee(Employee emp);
        Task<IEnumerable<Employee>> InsertEmployee(Employee emp);
        Task<IEnumerable<Employee>> DeleteEmployee(Employee emp);
    }
}
