namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const string TalkAbility = "Woof!";
        private const double WeightIncrease = 0.40;

        public Dog(string name, double weight, string regoin)
            : base(name, weight, regoin)
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
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
