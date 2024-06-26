﻿using System.Linq.Expressions;
using Vehicles.Models.Interfaces;

namespace Vehicles
{
    public abstract class Vehicle : IDrivable , IRefueable
    {
		private double _fuelQuantity;
		private double _fuelConsumptionPerKm;
        private double _tankCapacity ;

        protected Vehicle(double tankCapacity, double fuelConsumptionPerKm, double fuelQuantity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double TankCapacity
        {
            get => _tankCapacity;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tank capacity must be positive number");
                }
                _tankCapacity = value;
            }
        }


       

        public  double FuelConsumptionPerKm
		{
			get => _fuelConsumptionPerKm; 
			protected set
			{
				if (value < 0)
				{
                    throw new ArgumentException("Consumption must be posititve number");
                }
                _fuelConsumptionPerKm = value;
			}
		}
		public  double FuelQuantity
		{
			get => _fuelQuantity; 
			protected set 
			{
				if (value <= 0)
				{
					throw new ArgumentException("Fuel must be a posititve number");
				}
                if (value <= TankCapacity)
                {
                    _fuelQuantity = value;
                }
                else
                {
                    _fuelQuantity = 0;
                }
			}
		}

        public void Drive(double distance)
        {
            var totalConsumptionPerTravel = distance * FuelConsumptionPerKm;
            if (totalConsumptionPerTravel > FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            FuelQuantity -= totalConsumptionPerTravel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            var totalFuelAfterRefueling = fuelAmount + FuelQuantity;
            if (totalFuelAfterRefueling > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }
            FuelQuantity += fuelAmount;
        }
    }
}
