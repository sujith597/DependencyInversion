using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreData.Interfaces;
using DBLayer;
using Microsoft.Practices.Unity;

namespace BusinessServicesLayer
{
    public class UnityResolver
    {
        public UnityResolver()
        {
            using (var container = new UnityContainer())
            {
                container.RegisterType<IEmployeeRepository, EmployeeRepository>();
                
            }
        }
    }
}
