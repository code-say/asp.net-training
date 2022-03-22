using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MyClass1
    {
        public void Method1()
        {
            Console.WriteLine("Method1 from MyClass1");
        }
    }
    class MyClass2 : MyClass1
    {
        public void Method2()
        {
            Console.WriteLine("Method2 from MyClass2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 obj1 = new MyClass1();
            MyClass2 obj2 = new MyClass2();
            obj2.Method1();
            obj2.Method2();
        }
    }
}
