namespace PizzaCalories
{
    public  class Topping
    {
        private const double BaseCalories = 2.0;
        private string _toppingType;

        public Topping(string toppingType, double toppingWeight)
        {
            ToppingType = toppingType;
            Weight = toppingWeight;
        }

        readonly double _weight;

        public double Weight
        {
            get => _weight;
            init
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                _weight = value;
            }
        }
        public string ToppingType
        {
            get => _toppingType;
            set
            {
                if (value.ToLower() is not ("meat" or "veggies" or "cheese" or "sauce"))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                _toppingType = value;
            }
        }
        public double CalculateCalorieaPerGram()
        {
            double calories = BaseCalories;

            switch (ToppingType.ToLower())
            {
                case "meat":
                    calories *= 1.2;break;
                case "veggies": calories *= 0.8;break;
                case "cheese": calories *= 1.1; break;
                case "sauce": calories *= 0.9; break;
            } ;
            return calories;

        }
    }
}
