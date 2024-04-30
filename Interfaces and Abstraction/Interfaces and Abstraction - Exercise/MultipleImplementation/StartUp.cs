// Using the code from the DefineAnInterfaceIPerson task, define an interface IIdentifiable with a string property Id and an interface IBirthable
// with a string property Birthdate and implement them in the Citizen class. Rewrite the Citizen constructor to accept the new parameters.

// Input:
// Peter
// 25
// 9105152287
// 15/05/1991

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}
