using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace FileHandlingDemo
{
    class DirectoryInfoDemo
    {
        static void Main(string[] args)
        {
            string path = @"D:\ MyDirectory";  // verbatim literal
            string path2 = @"D:\ MyDirectory 2";
            DirectoryInfo dir = new DirectoryInfo(path2);
            dir.Delete(true);

            //dir.MoveTo(path2);
            //dir.Create();
            //dir.CreateSubdirectory("Another Directory");
            //Console.WriteLine("Directory Created..");
            //Console.WriteLine("Directory Move..");
            Console.WriteLine("Directory Deleted..");
            Console.ReadLine();
        }
    }
}
