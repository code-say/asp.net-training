using LinqSample3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Select in LINQ
// Projection Operations

namespace LinqSample3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {  Id=1, Name = "Tom", Email="tom@gmail.com"},
                new Employee() {  Id=2, Name = "John", Email="john@gmail.com"},
                new Employee() {  Id=3, Name = "Mark", Email="mark@gmail.com"},
            };

            var basicQuery =( from emp in employees
                             select emp).ToList();

            foreach (var item in basicQuery)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
            Console.WriteLine("\n---------------------------------------------------");

            var basicMethod = employees.ToList();

            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }


            /// Operations
            /// 

            var basicPropQuery = (from emp in employees
                                  select emp.Id).ToList();  // emp.Id.ToString()

            var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            Console.WriteLine("----------------------------------------------------");

            var selectQuery = (from emp in employees
                               select new Employee()
                               {
                                   Id = emp.Id,
                                   Email = emp.Email
                               }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
            }


            Console.WriteLine("--------------------------------------------------------");

            var selectQuery1 = (from emp in employees
                               select new Student()
                               {
                                   StudentId = emp.Id,
                                   FullName = emp.Name,
                                   StEmail = emp.Email
                               }).ToList();

            foreach (var item in selectQuery1)
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName}, Email = {item.StEmail}");
            }

            Console.WriteLine("---------------------------------Inherit MethodQuery--------------------------");

            var selectMethod = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                FullName = emp.Name,
                StEmail = emp.Email
            }).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine($"Id = {item.StudentId}, Name = {item.FullName}, Email = {item.StEmail}");
            }

            Console.WriteLine("-----------------------Anonymous--------------------------------------");
            
            var selectQuery2 = (from emp in employees
                                select new 
                                {
                                    CustomId = emp.Id,
                                    CustomName = emp.Name,
                                    CustomEmail = emp.Email
                                }).ToList();


            foreach (var item in selectQuery2)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }

            var selectMethod1 = employees.Select(emp => new 
            {
                CustomId = emp.Id,
                CustomName = emp.Name,
                CustomEmail = emp.Email

            }).ToList();

            foreach (var item in selectMethod1)
            {
                Console.WriteLine($"Id = {item.CustomId}, Name = {item.CustomName}, Email = {item.CustomEmail}");
            }

            Console.ReadLine();
        }
    }
}
