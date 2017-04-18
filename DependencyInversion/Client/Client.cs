using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessServicesLayer;
using CoreData;
using CoreData.Interfaces;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
           IEmployeeService _employeeService = new EmployeeService();
            Console.WriteLine("Adding Different Employees");
            for (int i = 0; i < 10; i++)
            {
                _employeeService.AddEmployee(new Employee
                {
                    FirstName = "Sujith"+i,
                    LastName = "Kumar"+i,
                    EmailId = "SujithKumar@gmail.com"+i
                });
                Console.WriteLine("Successfully added Sujith" + i);
            }

            Console.WriteLine("Showing All employees");

            foreach (var Emp in _employeeService.GetAllEmployees())
            {
                Console.WriteLine(Emp.FirstName);
            }

            Console.ReadLine();

        }

    }
}
