// Your totalitarian dystopian society suffers a shortage of food, so many rebels appear. Extend the code from your previous task with new functionality
// to solve this task.
// Define a class Rebel which has a name, age, and group (string), names are unique - there will never be 2 Rebels/Citizens or a Rebel
// and Citizen with the same name. Define an interface IBuyer which defines a method BuyFood() and an integer property Food.
// Implement the IBuyer interface in the Citizen and Rebel class, both Rebels and Citizens start with 0 food, when a Rebel buys food his Food increases
// by 5, when a Citizen buys food his Food increases by 10.
// On the first line of the input you will receive an integer N - the number of people, on each of the next N lines you will receive information
// in one of the following formats "<name> <age> <id> <birthdate>" for a Citizen or "<name> <age><group>" for a Rebel. After the N lines, until the
// command "End" is received, you will receive names of people who bought food, each on a new line.Note that not all names may be valid, in case of
// an incorrect name - nothing should happen.

// Output
// The output consists of only one line on which you should print the total amount of food purchased.

// Input:                                                            Output:
// 2                                                                 20
// Peter 25 8904041303 04/04/1989
// Stan 27 WildMonkeys
// Peter
// George
// Peter
// End


using FoodStorage.Models;
using FoodStorage.Models.Interfaces;

namespace FoodStorage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           int counter = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>(); 
            for (int i = 0; i < counter; i++)
            {
                string[] currentBuyer = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (currentBuyer.Length == 3)
                {
                    buyers.Add(new Rebel(currentBuyer[0], int.Parse(currentBuyer[1]), currentBuyer[2]));
                }
                else
                {
                    buyers.Add(new Citizen(currentBuyer[0], currentBuyer[2], int.Parse(currentBuyer[1]), currentBuyer[3]));
                }
            }

            string command = default;
            while ((command = Console.ReadLine()) != "End")
            {
                string currentName = command;
                if (IsItExist(currentName, buyers))
                {
                    buyers.FirstOrDefault(b => b.Name == currentName).BuyFood();
                }
            }
            int buyedFood = 0;

            foreach (var buyer in buyers)
            {
                buyedFood += buyer.Food;
            }
            Console.WriteLine(buyedFood);
        }

        private static bool IsItExist(string currentName, List<IBuyer> buyers)
        {
            return buyers.Any(b => b.Name == currentName);
        }
    }
}
