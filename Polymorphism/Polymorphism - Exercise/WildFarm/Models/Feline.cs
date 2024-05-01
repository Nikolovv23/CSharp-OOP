namespace WildFarm.Models
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string regoin, string breed)
            : base(name, weight, regoin)
        {
            Breed = breed;
        }

        public string Breed { get;  protected set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
