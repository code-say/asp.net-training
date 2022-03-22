using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    class ObjectInitializer
    {
        int age;
        string name;
        char gender;

        static void Main(string[] args)
        {
            ObjectInitializer p1 = new ObjectInitializer { name = "Anadi", gender = 'M', age = 28 };
        }
    }
}
