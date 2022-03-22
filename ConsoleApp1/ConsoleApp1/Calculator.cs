using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("---------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Multi");
            Console.WriteLine("4.Divide");
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter you Choice 1 to 4");
            int cal = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            switch (cal)
            {
                case 1:
                    Console.Write("Enter First Number :");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second Number :");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Total Number is :" + c);
                    break;

                case 2:
                    Console.Write("Enter First Number :");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second Number :");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Total Number is :" + c);
                    break;

                case 3:
                    Console.Write("Enter First Number :");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second Number :");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Total Number is :" + c);
                    break;

                case 4:
                    Console.Write("Enter First Number :");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second Number :");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Total Number is :" + c);
                    break;
            }
            Console.Read();
        }
    }
}
