using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee _employee);

    }
}
