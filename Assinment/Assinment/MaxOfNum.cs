using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment
{
    class MaxOfNum
    {
        public static void Main()
        {
            int a, b, c, d, e;
            Console.WriteLine("Enter Number of A ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of B ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of C ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of D ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Of E ");
            e = Convert.ToInt32(Console.ReadLine());


            if(a>b && a>c && a>d && a>e)
            {
                Console.WriteLine(a + " is Max Number");
            }
            else if(b>a && b>c && b>d && b>e)
            {
                Console.WriteLine(b + " is Max Number");
            }
            else if(c>a && c>b && c>d && c>e)
            {
                Console.WriteLine(c + " is Max Number");
            }
            else if(d>a && d>b && d>c && d>e)
            {
                Console.WriteLine(d + " is Max Number");
            }
            else
            {
                Console.WriteLine(e + " is Max Number");
            }
            Console.ReadKey();
        }
    }
}
