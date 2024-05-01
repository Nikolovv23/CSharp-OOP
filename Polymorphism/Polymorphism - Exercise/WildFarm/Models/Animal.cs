using System;
namespace WildFarm.Models
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public abstract void Eat(Food food);
        public abstract string Talk();

    }
}
