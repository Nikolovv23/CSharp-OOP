namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelConsumptionModifier = 1.6;

        public Truck(double tankCapacity, double fuelConsumptionPerKm, double fuelQuantity) 
            : base(tankCapacity, fuelConsumptionPerKm + FuelConsumptionModifier, fuelQuantity)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            var totalFuelAfterRefueling = fuelAmount * 0.95 + FuelQuantity;
            if (totalFuelAfterRefueling > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }
            FuelQuantity += fuelAmount * 0.95;
        }
    }
}
