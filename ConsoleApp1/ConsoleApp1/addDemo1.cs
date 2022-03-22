using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class addDemo1
    {
        static void Main(String[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter your firstNumber : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //int num1 = Console.ReadLine();
            Console.WriteLine("Enter your secondNumber : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Console.ReadLine();
            int sum = num1 + num2;
            Console.WriteLine("Your totalNumber is : " + sum.ToString());
            Console.ReadLine();
        }
    }
}
