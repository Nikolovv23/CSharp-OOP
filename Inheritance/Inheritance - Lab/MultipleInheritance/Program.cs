﻿// Create three classes named Animal, Dog, and Puppy:
// •	Animal with a single public method Eat() that prints: "eating…"
// •	Dog with a single public method Bark() that prints: "barking…"
// •	Puppy with a single public method Weep() that prints: "weeping…"
// •	Dog should inherit from Animal
// •	Puppy should inherit from Dog

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

        }
    }
}
