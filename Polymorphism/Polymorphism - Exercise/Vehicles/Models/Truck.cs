namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelConsumptionModifier = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm + FuelConsumptionModifier)
        {
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(0.95 * fuelAmount);
        }
    }
}
