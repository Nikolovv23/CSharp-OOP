﻿// Look at the image in Hierarchy folder and build a hierarchy of interfaces and classes:

// Output
// Grey Seat Leon
// Engine start
// Breaaak!
// Red Tesla Model 3 with 2 Batteries
// Engine start
// Breaaak!

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");

            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(seat.Start());
            Console.WriteLine(seat.Stop());

            Console.WriteLine(tesla.ToString());

            Console.WriteLine( tesla.Start());
            Console.WriteLine( tesla.Stop());
        }
    }
}