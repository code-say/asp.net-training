using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] ages = { 10, 5, 12, 20, 18 };
            Console.WriteLine("Number on index 0 : " + ages[0]);
            int onIndex2 = ages[2];
            Console.WriteLine("age on index 2 : " + ages[2]);
            ages[2] = ages[2] + 1;
            Console.WriteLine("age on index 2 : " + ages[2]);
            Console.WriteLine("onIndex2 : " + onIndex2);

            string[] names = { "Adam", "Ava", "Paul", "Emily" };
            string name = names[1];
            names[1] = "peter";
            Console.WriteLine(name);
            Console.WriteLine(names[1]);
            Console.ReadLine();
        }
        
    }
}
