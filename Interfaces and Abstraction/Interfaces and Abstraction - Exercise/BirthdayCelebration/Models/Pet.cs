using BirthdayCelebration.Models.Interfaces;

namespace BirthdayCelebration.Models
{
    public class Pet : IBorn
    {
        public Pet(string name, string date)
        {
            Name = name;
            Date = date;
        }

        public string Name { get; init; }
        public string Date { get; init; }
    }
}
