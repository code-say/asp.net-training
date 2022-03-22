using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Array.Copy(arr, 0, arr2, 0, 10);
            Console.WriteLine("New Array by using Array. copy method");
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

            /*Sorting Array Asc order */
            Console.WriteLine("Sorting Array Asc order");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            /*Sorting Array Desc order */
            Console.WriteLine("Sorting Array Desc order");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


            /*Clearing  Array   */

            Array.Clear(arr, 0, 5);
            Console.WriteLine("Array after Clearing first 5 values from  Array");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            /*Taking Input from End User from Console*/

             String[] arr3 = new String[10];
            String name;
            Console.WriteLine("Enter your Names");
            Console.Write("Input 10 elements in the array :\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr3[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("List of All Names");
            foreach (String i in arr3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
