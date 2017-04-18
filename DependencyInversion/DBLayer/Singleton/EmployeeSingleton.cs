using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreData;

namespace DBLayer.Singleton
{
    class EmployeeSingleton
    {
        private static EmployeeSingleton _employeeSingleton;
        private List<Employee> EmployeeList = new List<Employee>();

        public EmployeeSingleton getInstance()
        {
            if (_employeeSingleton == null)
            {
                _employeeSingleton = new EmployeeSingleton();
            }
            return _employeeSingleton;
        }

        public List<Employee> ListOfEmployee()
        {
            return EmployeeList;
        }

        public void AddEmployee(Employee _employee)
        {
            EmployeeList.Add(_employee);


        }
    }
}
