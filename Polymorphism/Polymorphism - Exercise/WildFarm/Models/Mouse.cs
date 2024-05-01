namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const string TalkAbility = "Squeak";
        private const double WeightIncrease = 0.10;

        public Mouse(string name, double weight, string regoin) 
            : base(name, weight, regoin)
        {
        }
        public override void Eat(Food food)
        {
            string foodKind = food.GetType().Name;
            int foodPieces = food.Quantity;
            if (foodKind.ToLower() is not "meat" or "fruit")
            {
                Weight += foodPieces * WeightIncrease;
                FoodEaten = foodPieces;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {foodKind}!");

            }
            

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
