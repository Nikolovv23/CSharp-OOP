// The skeleton from the "Validation" task could be used.
// Create a Team class. Add to this team all of the people you have received. Those who are younger than 40 go to the first team,
// others go to the reserve team. At the end print the sizes of the first and the reserved team.
// The class should have private fields for:
// •	name: string
// •	firstTeam: List < Person >
// •	reserveTeam: List < Person >
// The class should have constructors:
// •	Team(string name)
// The class should also have public properties for:
// •	FirstTeam: List<Person>(read - only!)
// •	ReserveTeam: List<Person>(read - only!)
// And a method for adding players:
// •	AddPlayer(Person person): void

//     Input
// 5
// Andrew Williams 20 2200
// Newton Holland 57 3333
// Rachelle Nelson 27 600
// Grigor Dimitrov 25 666.66
// Brandi Scott 35 555
//     Output
// First team has 4 players.
// Reserve team has 1 players.



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
                try
                {
                    var person = new Person(cmdArgs[0],
                                 cmdArgs[1],
                                 int.Parse(cmdArgs[2]),
                                 decimal.Parse(cmdArgs[3]));
                    persons.Add(person);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }
            Team team = new Team("SoftUni");
            foreach (var person in persons)
            {
                team.AddPlayer(person);
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Second team has {team.ReserveTeam.Count} players.");


        }
    }
}
