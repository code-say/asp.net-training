using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment
{
    class Swap
    {
        static void Main(String[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first Numbetr ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping ..");
            Console.WriteLine("FirstNumber : " + num1);
            Console.WriteLine("SecondNumber : " + num2);
            Console.ReadKey();
        }
    }
}
