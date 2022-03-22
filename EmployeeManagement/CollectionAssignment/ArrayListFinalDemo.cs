using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class ArrayListFinalDemo
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            myList.Add("Mandal");
            myList.Add("Sayan");
            myList.Add("Yash");
            Console.WriteLine(myList.Capacity);

            //myValues.AddRange(new ArrayList(){"Sayan",22,5000 });

            //myValues.Insert(1, "sayan");
            //myValues.Insert(2, "rahul");
            //myValues.Insert(3, "yash");

            foreach (object obj in myList)
            {
                Console.Write(obj + " ");  
            }
            Console.WriteLine();
            myList.Insert(0, "Shiv");

            foreach (object obj in myList)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();

            //myList.Remove("Mandal");
            myList.RemoveAt(1);

            foreach (object obj in myList)
            {
                Console.Write(obj + " ");
            }

            Console.ReadKey();

        }
    }
}
