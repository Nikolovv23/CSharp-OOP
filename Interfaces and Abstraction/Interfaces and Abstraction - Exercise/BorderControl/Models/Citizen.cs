using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string id)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        public string Id { get; init; }
        public int Age { get; private set; }
        public string Name { get; set; }


    }
}
