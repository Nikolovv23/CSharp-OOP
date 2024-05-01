// Your task is to create a class hierarchy like the one described below. The BaseHero class should be abstract.
// •	BaseHero – string Name, int Power, string CastAbility()
// 	Druid – power = 80
// 	Paladin – power = 100
// 	Rogue – power = 80
// 	Warrior – power = 100
// Each hero should override the CastAbility() method:
// Druid - "{Type} - {Name} healed for {Power}"
// Paladin - "{Type} - {Name} healed for {Power}"
// Rogue - "{Type} - {Name} hit for {Power} damage"
// Warrior - "{Type} - {Name} hit for {Power} damage"
// Now use the classes you created to form a raid group and defeat a boss. You will receive an integer N from the console.
// On the next lines, you will receive {heroName} and {heroType} until you create N number of heroes.
// If the hero type is invalid print: "Invalid hero!" and don’t add it to the raid group.
// After the raid group is formed you will receive an integer from the console which will be the boss’s power.
// Then each of the heroes in the raid group should cast his ability once.
// You should sum the power of all of the heroes and if the total power is greater or equal to the boss’s power you have defeated him and you should print:
// "Victory!"
// Else print:
// "Defeat..."
//     Constraints
// You need to create heroes until you have N amount of valid heroes.

//     Input:
// 3
// Mike
// Paladin
// Josh
// Druid
// Scott
// Warrior
// 250
//     Output:
// Paladin - Mike healed for 100
// Druid - Josh healed for 80
// Warrior - Scott hit for 100 damage
// Victory!

using Heroes.Models;
namespace Heroes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int heroesCount = int.Parse(Console.ReadLine());
             while (heroes.Count < heroesCount)
             {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                switch (heroType)
                {
                    case "Druid":
                        heroes.Add(new Druid (heroName));
                        break;
                    case "Paladin":
                        heroes.Add (new Paladin (heroName));
                        break;
                    case "Rogue":
                        heroes.Add(new Rogue(heroName));
                        break;
                    case "Warrior":
                        heroes.Add(new Warrior(heroName));
                        break;
                        default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
             }
            foreach (BaseHero hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }
            int result = heroes.Sum(h => h.Power);
            int bossPower = int.Parse(Console.ReadLine());

            Console.WriteLine(result >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}
