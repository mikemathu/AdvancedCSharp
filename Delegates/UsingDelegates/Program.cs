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
            //Create MathDelegate object
            //that "point to" Mathe.Add
            
            MathDelegate mathOperation = new MathDelegate(Mathe.Add);
            int a = 5;
            int b = 7;

            int result = mathOperation(a, b);

            Console.WriteLine(result);

        }



       


    }
    

}
