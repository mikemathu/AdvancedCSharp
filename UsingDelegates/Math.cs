using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMathDelegates
{
    internal class Mathe
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Power(int baseNumber, int exponent)
        {
            return (int)Math.Pow(baseNumber, exponent);
        }
    }
}
