using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int swiched = 5;
            int result = 0;
            switch (swiched)
            {
                case 1:
                    result = 10;
                    break;
                case 2:
                    result = 50;
                    break;
                default:
                    result = 100;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
