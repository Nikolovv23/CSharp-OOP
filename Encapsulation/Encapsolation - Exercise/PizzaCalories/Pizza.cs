namespace PizzaCalories
{
	public class Pizza
	{
		private string _name;
        private List<Topping> _toppings;

		public Pizza(string name )
		{
			Name = name;
			_toppings = new List<Topping>();
		}
        public Dough Dough { get; set; }
        public string Name
		{
			get => _name;
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
				}
				if (value.Length is < 1 or > 15)
				{
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                _name = value;

			}

		}

		public void AddToppings(Topping topping)
		{
			if (_toppings.Count == 10)
			{
				throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
			_toppings.Add(topping);
		}
		public double Calories
		{
			get
			{
				double total = this.Dough.CaloriesPerGram * this.Dough.Weight;
				foreach (var topping in _toppings)
				{
					total += topping.Weight * topping.CalculateCalorieaPerGram();
				}
				return total;
			}
		}
	}
}
