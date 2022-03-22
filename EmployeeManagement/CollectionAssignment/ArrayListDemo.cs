using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class ArrayListDemo
    {
        static void Main(String[] args)
        {
            var names = new List<string>();
            names.Add("sayan");
            names.Add("Rahul");
            names.Add("mandal");
            names.Add("deva");
            names.Add("shiv");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
