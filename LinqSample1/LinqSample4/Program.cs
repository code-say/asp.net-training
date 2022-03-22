using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample4
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        public static List<Student> students = new List<Student>
        {
            new Student{Id=101,Name="John",Age=25,City="Kolkata"},
            new Student{Id=102,Name="Kiran",Age=24,City="Mumbai"},
            new Student{Id=103,Name="Suresh",Age=23,City="Bangalore"},
            new Student{Id=104,Name="Prem",Age=22,City="Pune"},
            new Student{Id=105,Name="Sunanda",Age=21,City="Chennai"},
            new Student{Id=106,Name="Srinivas",Age=20,City="Gujrat"},
        };
        static void Main(string[] args)
        {
            Console.WriteLine(students.Count);

            //foreach (var x in students)
            //{
            //    if(x.Age==25)
            //    {
            //        Console.WriteLine(x.Id+" "+x.Name+" "+x.Age);
            //    }
            //}

            foreach (var x in students.Where(y => y.Age == 25))
            {
                Console.WriteLine($"{x.Id} {x.Name} {x.Age}");
            }
            Console.WriteLine("------------------------------------------");

            foreach (var x in students.OrderBy(y=>y.Age))
            {
                Console.WriteLine($"{x.Id} {x.Name} {x.Age}");
            }

            Console.WriteLine("------------------------------------------");

            foreach (var x in students.OrderByDescending(y => y.Age))
            {
                Console.WriteLine($"{x.Id} {x.Name} {x.Age}");
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine(students.Count(y => y.Age >= 25));
            Console.WriteLine(students.Count(y=>y.Name.StartsWith("s")));

            Console.WriteLine("------------------------------------------");
            students.Where(y => y.Age == students.Min(z => z.Age));

            Console.ReadKey();
        }
    }
}
