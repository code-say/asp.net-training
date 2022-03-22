using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileHandlingDemo
{
    class Program2
    {
        static void Main(string[] args)
        {
            string path = @"D:\data.txt";  // verbatim literal
            string path2 = @"D:\data1.txt";  // verbatim literal
            File.Copy(path, path2,true);
            Console.ReadLine();
        }
    }
}
