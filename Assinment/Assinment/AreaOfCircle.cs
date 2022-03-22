using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment
{
    class AreaOfCircle
    {
        double area(double r)
        {
            double PI = 3.14;
            return (PI * r * r);
        }

        double cirum(double r)
        {
            double PI = 3.14;
            return (2 * PI * r);
        }
        public static void Main()
        {
            double r;
            AreaOfCircle a1 = new AreaOfCircle();
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            double area;
            area = a1.area(r);
            Console.WriteLine("Area of the Cirlce is " + area);
            double cirumference;
            cirumference = a1.cirum(r);
            Console.WriteLine("Cirumference of Circle " + cirumference);
            Console.Read();
        }
    }
}
