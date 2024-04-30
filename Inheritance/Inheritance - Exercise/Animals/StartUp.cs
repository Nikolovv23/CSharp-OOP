// You need a public class StartUp.Create a hierarchy of Animals. Your program should have three different animals –
// Dog, Frog, and Cat. Deeper in the hierarchy you should have two additional classes – Kitten and Tomcat.
// Kittens are female and Tomcats are male. All types of animals should be able to produce some kind of sound - ProduceSound().
// For example, the dog should be able to bark. Your task is to model the hierarchy and test its functionality.
// Create an animal of each kind and make them all produce sound.
// You will be given some lines of input. Every two lines will represent an animal.
// On the first line will be the type of animal and on the second – the name, the age, and the gender.
// When the command "Beast!" is given, stop the input and print all the animals in the format shown below.
// Output
// •	Print the information for each animal on three lines. On the first line, print: "{AnimalType}"
// •	On the second line print: "{Name} {Age} {Gender}"
// •	On the third line print the sounds it produces: "{ProduceSound()}"
// Constraints
// •	Each Animal should have a name, an age, and a gender
// •	All input values should not be blank (e.g. name, age, and so on…)
// •	If you receive an input for the gender of a Tomcat or a Kitten, ignore it but create the animal
// •	If the input is invalid for one of the properties, throw an exception with the message: "Invalid input!"
// •	Each animal should have the functionality to ProduceSound()
// •	Here is the type of sound each animal should produce:
// o Dog: "Woof!"
// o Cat: "Meow meow"
// o Frog: "Ribbit"
// o Kittens: "Meow"
// o Tomcat: "MEOW"

// Example:       Input
//            Cat
//            Tom 12 Male
//            Dog
//            Buddy 132 Male
//            Beast!
//                Output
//            Cat 
//            Tom 12 Male
//            Meow meow
//            Dog 
//            Buddy 132 Male
//            Woof!




using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType = default;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                   if (animalType == "Dog")
                   {
                        var dog = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(dog.GetType().Name);
                        Console.WriteLine(dog);
                        Console.WriteLine(dog.ProduceSound());
                   }
                    if (animalType == "Cat")
                    {
                        var cat = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(cat.GetType().Name);
                        Console.WriteLine(cat);
                        Console.WriteLine(cat.ProduceSound());
                    }
                    if (animalType == "Frog")
                    {
                        var frog = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(frog.GetType().Name);
                        Console.WriteLine(frog);
                        Console.WriteLine(frog.ProduceSound());
                    }
                    if (animalType == "Kitten")
                    {
                        var kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                        Console.WriteLine(kitten.GetType().Name);
                        Console.WriteLine(kitten);
                        Console.WriteLine(kitten.ProduceSound());
                    }
                    if (animalType == "Tomcat")
                    {
                        var tomcat = new Tomcat(animalData[0], int.Parse(animalData[1]));
                        Console.WriteLine(tomcat.GetType().Name);
                        Console.WriteLine(tomcat);
                        Console.WriteLine(tomcat.ProduceSound());
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
