using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreData;
using CoreData.Interfaces;
using DBLayer; // Here we can remove DB Layer Entire from references.

namespace BusinessServicesLayer
{
    public class EmployeeService : UnityResolver, IEmployeeService
    {
        public IEmployeeRepository _EmployeeRepository; // Depending upon Interface and Repository depends on Interface 
        // Here we achieved Inversion of control using abstraction. 
        
        public EmployeeService(IEmployeeRepository employeeRepository) // Here Employee Service not dealing with creating of Repository Object
        {
            // Some one just injecting repository into Employee service and It just assigning it. 
            _EmployeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            return _EmployeeRepository.GetEmployees();
        }

        public void AddEmployee(Employee _employee)
        {
            _EmployeeRepository.AddEmployee(_employee);
        }
    }
}
