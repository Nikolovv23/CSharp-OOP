
namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const string TalkAbility = "Hoot Hoot";
        private const double WeightIncrease = 0.25;


        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            string foodKind = food.GetType().Name;
            int foodPieces = food.Quantity;
            if (foodKind.ToLower() != "meat")
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {foodKind}!");
            }
            Weight += foodPieces * WeightIncrease;
            FoodEaten = foodPieces;

        }
        public override string Talk()
        {
            return TalkAbility;
        }
    }

}
