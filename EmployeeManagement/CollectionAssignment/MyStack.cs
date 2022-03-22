using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class MyStack
    {
        static void Main(String[] args)
        {
            Stack my_stack = new Stack();
            Console.WriteLine("Enter Size of  Stack ");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names Which you wont to Store : ");
            for (int i = 0; i < arrsize; i++)
            {
                Console.Write("element - {0} : ", i);
                String name = Convert.ToString(Console.ReadLine());
                my_stack.Push(name);
            }
            Console.WriteLine("Totall Entered Names Stored in Array : ");
            foreach (String i in my_stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Execution of Pop method " + "my_stack: {0}", my_stack.Pop());
            Console.WriteLine("After Execution of Pop method ");
            Console.WriteLine("After Pop, Peek element: " + "my_stack: {0}", my_stack.Peek());

        }
    }
}
