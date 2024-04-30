namespace PizzaCalories
{
    public class Dough
    {
        private const double BaseCalories = 2.0;
		readonly string _flourType;

		readonly string _bakingtechnique;

		public Dough(string flourType, string backingTechnique, double weight)
		{
			FlourType = flourType;
			BakingTechnique = backingTechnique;
			Weight = weight;
		}

		readonly double _weight;

		public double Weight		{
			get => _weight; 
			init 
			{
                if (value < 1 || value > 200)
                {
					throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                _weight = value; 
			}
		}

		public  string BakingTechnique
		{
			get => _bakingtechnique; 
			init
			{ 
				if (value.ToLower() is not ("crispy" or "chewy" or "homemade"))
			    {
					throw new ArgumentException("Invalid type of dough.");
			    }
				_bakingtechnique = value; 
			}
		}

		public  string FlourType
		{
			get =>  _flourType; 
			init
			{
				if (value.ToLower() is not ("white" or "wholegrain"))
				{
					throw new ArgumentException("Invalid type of dough.");
				}
				_flourType = value;
			}
		}

		public double CaloriesPerGram
		{
			get
			{
				double caloriesPerGram = BaseCalories;
				if (_flourType.ToLower() == "white")
				{
					caloriesPerGram *= 1.5;
				}

				switch (_bakingtechnique.ToLower())
				{
					case "crispy":
						caloriesPerGram *= 0.9;break;
					case "chewy":
						caloriesPerGram *= 1.1;break;
				}
				return caloriesPerGram;
			}
		}
	}
}
