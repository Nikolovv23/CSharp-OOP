using FoodStorage.Models.Interfaces;

namespace FoodStorage.Models
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, string id, int age, string date)
        {
            Id = id;
            Age = age;
            Name = name;
            Date = date;
        }

        public string Id { get; init; }
        public int Age { get; private set; }
        public string Name { get; set; }
        public string Date { get; init; }

        public int Food { get; set; }
        public void BuyFood ()
        {
            Food += 10;
        }


    }
}
