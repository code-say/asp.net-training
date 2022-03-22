using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class evenOdd
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Even Numbers");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i + " Odd Numbers");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
