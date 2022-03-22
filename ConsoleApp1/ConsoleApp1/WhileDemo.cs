using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WhileDemo
    {
        static void Main(string[] args)
        {
            int temp = 0;
            while (temp < 5)
            {
                temp++;
            }
            Console.WriteLine(temp);

            int[] arr = { 10, 20, 30, 40 };
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i++;
            }
        }
    }
}
