// Your task is to create a class hierarchy like the one described below. The Animal, Bird, Mammal, Feline, and Food classes should be abstract. Override the method ToString().
// •	Food – int Quantity
// 	Vegetable
// 	Fruit
// 	Meat
// 	Seeds
// •	Animal – string Name, double Weight, int FoodEaten
// 	Bird – double WingSize
// 	Owl
// 	Hen
// 	Mammal – string LivingRegion
// 	Mouse
// 	Dog
// 	Feline – string Breed
// •	Cat
// •	Tiger
// All animals should also have the ability to ask for food by producing a sound.
// •	Owl – "Hoot Hoot"
// •	Hen – "Cluck"
// •	Mouse – "Squeak"
// •	Dog – "Woof!"
// •	Cat – "Meow"
// •	Tiger – "ROAR!!!"
// Now use the classes that you have created to instantiate some animals and feed them.
// Input should be read from the console. Every even line (starting from 0) will contain information about an animal in the following format:
// •	Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}"
// •	Birds - "{Type} {Name} {Weight} {WingSize}"
// •	Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"
// On the odd lines, you will receive information about a piece of food that you should give to that animal. The line will consist of a FoodType and quantity, separated by whitespace.
// Animals will only eat a certain type of food, as follows:
// •	Hens eat everything
// •	Mice eat vegetables and fruits
// •	Cats eat vegetables and meat
// •	Tigers, Dogs, and Owls eat only meat
// If you try to give an animal a different type of food, it will not eat it and you should print:
// •	"{AnimalType} does not eat {FoodType}!"
// The weight of an animal will increase with every piece of food it eats, as follows:
// •	Hen - 0.35
// •	Owl - 0.25
// •	Mouse - 0.10
// •	Cat - 0.30
// •	Dog - 0.40
// •	Tiger - 1.00
// Override the ToString() method to print the information about an animal in the formats:
// •	Birds - "{AnimalType} [{AnimalName}, {WingSize}, {AnimalWeight}, {FoodEaten}]"
// •	Felines - "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"
// •	Mice and Dogs - "{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"
// After you have read the information about the animal and the food, the animal will produce a sound (print it on the console). Next, you should try to feed it. After receiving the "End" command, print information about every animal in order of input.

//      Input:
// Tiger Rex 167.7 Asia Bengal
// Vegetable 1
// Dog Tommy 500 Street 
// Vegetable 150
// End
//      Output:
// ROAR!!!
// Tiger does not eat Vegetable!
// Woof!
// Dog does not eat Vegetable!
// Tiger [Rex, Bengal, 167.7, Asia, 0]
// Dog[Tommy, 500, Street, 0]
using WildFarm.Models;
namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string command = default;
            int line = 0;
            while((command = Console.ReadLine()) != "End")
            {
                try
                {
                    if (line % 2 == 0)
                    {
                        line++;
                        string[] animal = command
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                        string currenItem = animal[0];

                        switch (currenItem.ToLower())
                        {
                            case "owl":
                                animals.Add(new Owl(animal[1], double.Parse(animal[2]), double.Parse(animal[3])));
                                break;
                            case "hen":
                                animals.Add(new Hen(animal[1], double.Parse(animal[2]), double.Parse(animal[3])));
                                break;
                            case "cat":
                                animals.Add(new Cat(animal[1], double.Parse(animal[2]), animal[3], animal[4]));
                                break;
                            case "tiger":
                                animals.Add(new Tiger(animal[1], double.Parse(animal[2]), animal[3], animal[4]));
                                break;
                            case "dog":
                                animals.Add(new Dog(animal[1], double.Parse(animal[2]), animal[3]));
                                break;
                            case "mouse":
                                animals.Add(new Mouse(animal[1], double.Parse(animal[2]), animal[3]));
                                break;
                            default: break;
                        }
                        Console.WriteLine(animals.Last().Talk());

                    }
                    else
                    {
                        line++;
                        string[] currentFood = command
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                        switch (currentFood[0].ToLower())
                        {
                            case "fruit":
                                Food fruit = new Fruit(int.Parse(currentFood[1]));
                                animals.Last().Eat(fruit);
                                break;
                            case "meat":
                                Food meat = new Meat(int.Parse(currentFood[1]));
                                animals.Last().Eat(meat);
                                break;
                            case "vegetable":
                                Food vegetable = new Vegetable(int.Parse(currentFood[1]));
                                animals.Last().Eat(vegetable);
                                break;
                            case "seeds":
                                Food seeds = new Seeds(int.Parse(currentFood[1]));
                                animals.Last().Eat(seeds);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
