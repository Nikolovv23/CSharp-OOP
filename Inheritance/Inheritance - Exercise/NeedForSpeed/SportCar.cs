

namespace NeedForSpeed
{
    internal class SportCar : Car
    {
        private const double DefaultSportCarFuelConsumbtion = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultSportCarFuelConsumbtion;
    }
}
