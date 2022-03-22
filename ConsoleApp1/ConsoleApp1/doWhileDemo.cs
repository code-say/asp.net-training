using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class doWhileDemo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your number :");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------");

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);
            Console.Read();
        }
        
    }
}
