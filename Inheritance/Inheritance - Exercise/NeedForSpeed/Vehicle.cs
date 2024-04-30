namespace NeedForSpeed
{
    public class Vehicle
    {
        const double DefaultFuelConsumbtion = 1.25;
        public int HorsePower { get; set; }
        public double Fuel {  get; set; }
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual double FuelConsumption
        {
            get => DefaultFuelConsumbtion;
        }
        public virtual void Drive (double Kilometers)
        {
            Fuel -= FuelConsumption * Kilometers;
        }
    }
}
