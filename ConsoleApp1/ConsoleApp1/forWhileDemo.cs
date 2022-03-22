using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class forWhileDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. for loop");
            int b = 11;
            for (b = 0; b <= 10; b++)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("2. Using while Loop");
            int c = 1;
            while (c != 11)
            {
                Console.WriteLine(c);
                c++;
            }

            Console.Read();
        }
    }
}
