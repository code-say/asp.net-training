using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement;

namespace Assinment2
{
    public class Employeee
    {
       public static void Main()
        {
                Employee e1 = new Employee(1, "sayan", 25000);
                e1.CalculateGross();
                e1.CalculateSalary();
                Console.ReadKey();

        }
    }
}
