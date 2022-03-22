using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\data.txt";  // verbatim literal
            if(File.Exists(path))
            {
                Console.WriteLine("Yes there is a file..");
            }
            else
            {
                Console.WriteLine("File not Found..");
            }
            Console.ReadLine();
        }
    }
}
