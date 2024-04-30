// It is a well - known fact that people celebrate birthdays, it is also known that some people also celebrate their pets’ birthdays.
// Extend the program from your last task to add birthdates to citizens and include a class Pet, pets have a name and a birthdate.
// Encompass repeated functionality into interfaces and implement them in your classes. 
// You will receive from the console an unknown number of lines. Until the command "End" is received, each line will contain
// information in one of the following formats "Citizen <name> <age> <id> <birthdate>" for Citizen, "Robot <model> <id>" for Robot or
// "Pet <name> <birthdate" for Pet. After the "End" command on the next line, you will receive a single number representing a specific year,
// your task is to print all birthdates (of both Citizen and Pet) in that year in the format day/month/year in the order of input.

// Input:                                                                        Output:
// Citizen Peter 22 9010101122 10/10/1990                                        10/10/1990
// Pet Sharo 13/11/2005
// Robot MK-13 558833251
// End
// 1990

using BirthdayCelebration.Models;
using BirthdayCelebration.Models.Interfaces;

namespace BirthdayCelebration
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = default;
            List<IBorn> list = new List<IBorn>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (info[0] == "Pet")
                {
                    list.Add(new Pet(info[1], info[2]));
                }
                else if (info[0] == "Citizen")
                {
                    list.Add(new Citizen(info[1], int.Parse(info[2]), info[3], info[4]));
                }
                else { }

            }
            string checker = Console.ReadLine();

            foreach (var individual in list)
            {
                if (individual.Date.EndsWith(checker))
                {
                    Console.WriteLine(individual.Date);
                }
            }
        }
    }
}
