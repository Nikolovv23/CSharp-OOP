namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        private const string TalkAbility = "ROAR!!!";
        private const double WeightIncrease = 1.0;
        public Tiger(string name, double weight, string regoin, string breed)
            : base(name, weight, regoin, breed)
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
