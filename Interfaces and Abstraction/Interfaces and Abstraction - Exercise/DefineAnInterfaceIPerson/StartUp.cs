﻿// Define an interface IPerson with properties for Name and Age. Define a class Citizen that implements IPerson and has two properties
// string name and an int age. The Citizen should accept name and age upon initialization.

// Input:
// Peter
// 25

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
