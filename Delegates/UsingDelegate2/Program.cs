using System;
using SimpleDelegate;



    // Create a BinaryOp delegate object that
    // "points to" SimpleMath.Add().
    BinaryOp b = new BinaryOp(SimpleMath.Add);

    // Invoke Add() method indirectly using delegate object.
    Console.WriteLine("10 + 10 is {0}", b(10, 10));
    Console.ReadLine();

    //Additional type definitions must be placed at the end of the
    // top-level statements
    // This delegate can point to any method,
    // taking two integers and returning an integer.
    public delegate int BinaryOp(int x, int y);




