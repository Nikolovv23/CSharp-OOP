namespace WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string regoin) 
            : base(name, weight)
        {
            LivingRegion = regoin;
        }
        public string LivingRegion { get; protected set; }

    }
}
