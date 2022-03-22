using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollectionDemo
{
    class EmployeeRepository
    {
        public static List<Employee> InitializeEmp()
        {
            List<Employee> result = new List<Employee>();
            result.Add(new Employee(40, "sayan", 5000));
            result.Add(new Employee(42, "Rahul", 2500));
            result.Add(new Employee(43, "Test", 5600));
            return result;
        }
    }
}
