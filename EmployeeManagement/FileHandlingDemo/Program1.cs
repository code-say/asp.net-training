using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileHandlingDemo
{
    class Program1
    {
        static void Main(string[] args)
        {
            string path = @"D:\data.txt";  // verbatim literal

            if (File.Exists(path))
            {
                Console.WriteLine("File Found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File Not found");
            }
            Console.ReadLine();
        }
        
    }
}
