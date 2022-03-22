using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] topic;

            // allocating memory 
            topic = new string[] {"Array", "String",
                               "Stack", "Queue", "Exception", "Operators" };

            //Displaying Elements of
            // the array before reverse
            Console.WriteLine("Topic off c# before reverse:");
            Console.WriteLine();
            foreach (string ele in topic)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine();

            // using Reverse() method to
            // reverse the given array
            Array.Reverse(topic);

            // Displaying Elements of array after reverse
            Console.WriteLine("Topic of c# after reverse: ");
            Console.WriteLine();
            foreach (string val in topic)
            {
                Console.WriteLine(val + " ");
            }
            Console.WriteLine();
        }
    }
}
