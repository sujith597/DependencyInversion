using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee _employee);
    }
}
