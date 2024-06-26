﻿// Create a class Animal, which holds two fields:
// •	name: string
// •	favouriteFood: string
// An animal has one virtual method ExplainSelf(): string.
// You should add two new classes - Cat and Dog. Override the ExplainSelf() method by adding concrete animal sound on a new line. (Look at examples below)

// Output
// I am Peter and my fovourite food is Whiskas
// MEEOW
// I am George and my fovourite food is Meat
// DJAAF

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");

            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());

            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
