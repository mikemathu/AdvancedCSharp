using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingMathDelegates;

namespace UsingDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathDelegate mathOperation = Add;
            int a = 5;
            int b = 7;

            int result = mathOperation(a, b);

            Console.WriteLine(result);

        }



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
