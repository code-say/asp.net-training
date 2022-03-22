using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Constructor
    {
        static void Main(string[] args)
        {
            //var customer = new Customer(1, "Sayan");
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }
    }
}
