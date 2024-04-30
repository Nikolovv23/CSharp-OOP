using BirthdayCelebration.Models.Interfaces;

namespace BirthdayCelebration.Models
{
    public class Citizen : IIdentifiable, IBorn
    {
        public Citizen(string id, int age, string name, string date)
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


    }
}
