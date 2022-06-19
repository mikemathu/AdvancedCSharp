using System;
using SimpleDelegate;

namespace SimpleDelegate
{
    //This class contains methods BinaryOp will point to
    public class Program
    {
        // This delegate can point to any method,
        // taking two integers and returning an integer.
        public delegate int BinaryOp(int x, int y);

        // Create a BinaryOp delegate object that
        // "points to" SimpleMath.Add().
        BinaryOp b = new BinaryOp(SimpleMath.Add);

    }
}
