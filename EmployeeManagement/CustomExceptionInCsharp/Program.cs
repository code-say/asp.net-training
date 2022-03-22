using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = checkAGE();
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (CustomEx_AGE ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int checkAGE()
        {
            Console.WriteLine("Enter AGE: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
            {
                throw new Exception("AGE should be above 18");
            }
            return age;
        }
    }

    public class CustomEx_AGE : Exception
    {
        public CustomEx_AGE(string msg): base(msg)
        {

        }
    }
}
