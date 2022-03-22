using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmp = EmployeeRepository.InitializeEmp();


                      Console.WriteLine($"Before: There are {allEmp.Count} Emp:");
                       foreach (Employee emp in allEmp)
                           Console.WriteLine($"Emp: {emp}");
                        

                        allEmp.RemoveAt(2);


                     Console.WriteLine($"\r\nAfter: There are {allEmp.Count} Employee:");
                        foreach (Employee emp in allEmp)
                            Console.WriteLine($"Employee: {emp}");
            Console.ReadKey();
        }
        
    }
}
