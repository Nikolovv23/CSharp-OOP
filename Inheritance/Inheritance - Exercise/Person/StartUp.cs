﻿// You are asked to model an application for storing data about people. You should be able to have a person and a child. The child derives from the person. Your task is to model the application. The only constraints are:
// -People should not be able to have a negative age
// -	Children should not be able to have an age greater than 15.
// •	Person – represents the base class by which all of the others are implemented
// •	Child - represents a class, which derives from Person.

using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age > 15)
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);

            }
            else
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            

        }
    }
}