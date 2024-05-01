namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double FuelConsumptionModifier = 1.4;

        public Bus(double tankCapacity, double fuelConsumptionPerKm, double fuelQuantity) 
            : base(tankCapacity, fuelConsumptionPerKm, fuelQuantity)
        {
        }

        public void DriveWithPeople(double distance)
        {
            var totalConsumptionPerTravel = distance * (FuelConsumptionPerKm + FuelConsumptionModifier);
            if (totalConsumptionPerTravel > FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            FuelQuantity -= totalConsumptionPerTravel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
}
