﻿// Create a class Box, which has the following properties:
// •	Length - double, should not be zero or negative number
// •	Width - double, should not be zero or negative number
// •	Height - double, should not be zero or negative number
// If one of the properties is a zero or negative number throw ArgumentException with the message:
// "{propertyName} cannot be zero or negative." Use try-catch block to process the error.
// All properties are set by the constructor and when set, they cannot be modified.
// 
// Behavior
// double SurfaceArea()
// Calculate and return the surface area of the Box.
// double LateralSurfaceArea()
// Calculate and return the lateral surface area of the Box.
// double Volume()
// Calculate and return the volume of the Box.
// NOTE: You can find all formulas here.
// 
// Input
// •	On the first three lines, you will get the length, width, and height. 
// Output
// •	On the next three lines print the surface area, lateral surface area, and the volume of the box.


//     Input
// 2
// 3
// 4
//     Output
// Surface Area - 52.00
// Lateral Surface Area - 40.00
// Volume - 24.00


namespace ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
