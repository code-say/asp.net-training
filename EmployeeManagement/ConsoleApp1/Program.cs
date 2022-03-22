using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack S = new MyStack(4);

            try
            {
                S.push(25);
                S.push(35);
                S.push(45);
                S.push(56);
                //S.push(56);

            }
            catch (StackException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Items are : ");
            S.print();

            MyStack S1 = (MyStack)S.Clone();
            Console.WriteLine("Items  After clonning are: ");
            S1.print();
            try
            {
                S.pop();
                S.pop();
                S.pop();
                //S.pop();
                //S.pop();


            }
            catch (StackException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        
        }
    }
}
