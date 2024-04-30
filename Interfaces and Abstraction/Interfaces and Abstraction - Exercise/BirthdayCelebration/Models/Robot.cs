using BirthdayCelebration.Models.Interfaces;

namespace BirthdayCelebration.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Id = id;
            Model = model;
        }

        public string Id { get; init; }
        public string Model { get; init; }
    }
}
