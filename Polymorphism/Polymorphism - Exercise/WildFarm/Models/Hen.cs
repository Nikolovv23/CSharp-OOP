namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const string TalkAbility = "Cluck";
        private const double WeightIncrease = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }
        public override void Eat(Food food)
        {
            string foodKind = food.GetType().Name;
            int foodPieces = food.Quantity;
            Weight += foodPieces * WeightIncrease;
            FoodEaten = foodPieces;
        }
        public override string Talk()
        {
            return TalkAbility;
        }
    }
}
