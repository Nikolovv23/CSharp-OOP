namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const string TalkAbility = "Meow";
        private const double WeightIncrease = 0.30;
        public Cat(string name, double weight, string regoin, string breed) 
            : base(name, weight, regoin, breed)
        {
        }
        public override void Eat(Food food)
        {
            string foodKind = food.GetType().Name;
            int foodPieces = food.Quantity; 
            if (foodKind.ToLower() is "meat" or "vegetable")
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
    }
}
