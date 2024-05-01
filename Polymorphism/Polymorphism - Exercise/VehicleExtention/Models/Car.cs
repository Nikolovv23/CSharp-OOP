namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double FuelConsumptionModifier = 0.9;

        public Car(double tankCapacity, double fuelConsumptionPerKm, double fuelQuantity) 
            : base(tankCapacity, fuelConsumptionPerKm + FuelConsumptionModifier, fuelQuantity)
        {
        }
    }
}
