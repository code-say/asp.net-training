using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment
{
    class Array
    {
        public void SumOfArray(int[] arr, int size)
        {
            int res = 0;
            for (int i = 0; i < size; i++)
            {
                res = res + arr[i];
            }
            Console.WriteLine("The sum of the array is : " + res);
        }
    }
    class SumOfArrays
    {
        public static void Main()
        {

            int size;
            Console.WriteLine("Enter the size ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                int x;
                Console.WriteLine("Enter the data");
                x = Convert.ToInt32(Console.ReadLine());
                arr[i] = x;
            }
            Array a1 = new Array();
            a1.SumOfArray(arr, size);
            Console.ReadKey();
        }
    }
}
