// Refactor the project from the "Person" task.
// Create objects of the class Person. Read their name, age, and salary from the console.
// Read the percentage of the bonus to every Person's salary. People younger than 30 get half the increase.
// Expand Person from the previous task.
// 
// New properties and methods:
// •	Salary: decimal
// •	IncreaseSalary(decimal percentage)

//     Input
// 5
// Andrew Williams 65 2200
// Newton Holland 57 3333
// Rachelle Nelson 27 600
// Brandi Scott 44 666.66
// George Miller 35 559.4
// 20
//     Output
// Andrew Williams receives 2640.00 leva.
// Newton Holland receives 3999.60 leva.
// Rachelle Nelson receives 660.00 leva.
// Brandi Scott receives 799.99 leva.
// George Miller receives 671.28 leva.

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
