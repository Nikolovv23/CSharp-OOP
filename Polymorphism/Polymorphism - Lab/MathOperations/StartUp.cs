﻿// Create a class MathOperations, which should have 3 times method Add(). Method Add() has to be invoked with:
// •	Add(int, int): int
// •	Add(double, double, double): double
// •	Add(decimal, decimal, decimal): decimal

//Output
//5
//11
//9.9

namespace Operations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

        }
    }
}
