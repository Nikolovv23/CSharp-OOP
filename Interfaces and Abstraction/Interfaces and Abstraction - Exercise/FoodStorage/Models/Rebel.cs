using FoodStorage.Models.Interfaces;

namespace FoodStorage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Group = group;
            Age = age;
            Name = name;
        }

        public string Group { get; set; }
        public int Age { get; private set; }
        public string Name { get; set; }
        public int Food { get; set; }
        public void BuyFood()
        {
            Food += 5;
        }
    }
}
