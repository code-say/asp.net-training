using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
            Console.ReadLine();
        }

    /*    public Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        } */
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Sayan";
            person.Introduce("Mosh");
        }
    }
}
