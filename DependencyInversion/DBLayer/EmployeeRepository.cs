using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreData;
using CoreData.Interfaces;
using DBLayer.Singleton;

namespace DBLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeSingleton _employeeSingleton;
       
        public EmployeeRepository()
        {
            _employeeSingleton = new EmployeeSingleton();
        }

        public List<Employee> GetEmployees()
        {
            return _employeeSingleton.ListOfEmployee();
        }

        public void AddEmployee(Employee _employee)
        {
            _employeeSingleton.AddEmployee(_employee);
        }
    }
}
