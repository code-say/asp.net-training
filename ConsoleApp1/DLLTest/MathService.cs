using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLTest
{
    public static class MathService
    {
        public static int Divide(int x, int y)
        {

            if(y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }
    }
}
