// It’s the future, you’re the ruler of a totalitarian dystopian society inhabited by citizens and robots, since you’re afraid of rebellions you decide
// to implement strict control of who enters your city. Your soldiers check the Ids of everyone who enters and leaves.
// You will receive an unknown amount of lines from the console until the command "End" is received, on each line, there will be a piece of information
// for either a citizen or a robot who tries to enter your city in the format: "{name} {age} {id}" for citizens and "{model} {id}" for robots.
// After the "End" command on the next line, you will receive a single number representing the last digits of fake ids, all citizens or
// robots whose Id ends with the specified digits must be detained.
// The output of your program should consist of all detained Ids each on a separate line in the order of input.

//         Input
// Peter 22 9010101122
// MK - 13 558833251
// MK - 12 33283122
// End
// 122
//         Output
// 9010101122
// 33283122

using BorderControl.Models;
using BorderControl.Models.Interfaces;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = default;
            List<IIdentifiable> list = new List<IIdentifiable>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (info.Length == 2)
                {
                    list.Add(new Robot(info[0], info[1]));
                }
                else
                {
                    list.Add(new Citizen(info[0], int.Parse(info[1]), info[2]));
                }
            }
            string checker = Console.ReadLine();

            foreach (var individual in list)
            {
                if (individual.Id.EndsWith(checker))
                {
                    Console.WriteLine(individual.Id);
                }
            }
        }
    }
}
