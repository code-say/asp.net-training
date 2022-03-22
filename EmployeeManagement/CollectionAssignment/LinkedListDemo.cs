using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class LinkedListDemo
    {
       static void Main(string[] args)
        {
            LinkedList<String> my_list = new LinkedList<String>();
            Console.WriteLine("Enter Size of  Array ");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names Which you wont to Store : ");
            for (int i = 0; i < arrsize; i++)
            {
                Console.Write("element - {0} : ", i);
                String name = Convert.ToString(Console.ReadLine());
                my_list.AddLast(name);
            }
            Console.WriteLine("List Of Names which you entered : ");
            foreach (String name in my_list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Count of the Linked List ");
            if (my_list.Count > 0)
                Console.WriteLine(my_list.Count);
            else
                Console.WriteLine("LinkedList is empty");

        }
    }
  }
