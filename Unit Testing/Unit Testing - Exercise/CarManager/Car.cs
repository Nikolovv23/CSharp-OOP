
// You are provided with a simple project containing only one class -"Car".The provided class is simple -
// its main point is to represent some of the functionality of a car. Each car contains information about its Make, Model, Fuel Consumption, Fuel Amount,
// and Fuel Capacity. Also, each car can add some fuel to its tank by refueling and can travel distance by driving.
// To be driven, our car needs to have enough fuel. Everything in the provided skeleton is working perfectly fine and you mustn't change it.
// In the skeleton, you are provided Test Project named "CarManager.Tests". There you should place all the unit tests you write.
// The Test Project has only one class inside :
// •	"CarTests" - here you should place all code testing the "Car" and its functionality.
// Your job now is to write unit tests on the provided project and its functionality.You should test exactly every part of the code inside the "Car" class:
// •	You should test all the constructors
// •	You should test all properties (getters and setters)
// •	You should test all the methods and validations inside the class

using System;

namespace CarManager
{
    public class Car
    {
        private string make;

        private string model;

        private double fuelConsumption;

        private double fuelAmount;

        private double fuelCapacity;

        private Car()
        {
            this.FuelAmount = 0;
        }

        public Car(string make, string model, double fuelConsumption, double fuelCapacity) : this()
        {
            this.Make = make;
            this.Model = model;
            this.FuelConsumption = fuelConsumption;
            this.FuelCapacity = fuelCapacity;
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Make cannot be null or empty!");
                }

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }

                this.model = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel consumption cannot be zero or negative!");
                }

                this.fuelConsumption = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel amount cannot be negative!");
                }

                this.fuelAmount = value;
            }
        }

        public double FuelCapacity
        {
            get
            {
                return this.fuelCapacity;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel capacity cannot be zero or negative!");
                }

                this.fuelCapacity = value;
            }
        }

        public void Refuel(double fuelToRefuel)
        {
            if (fuelToRefuel <= 0)
            {
                throw new ArgumentException("Fuel amount cannot be zero or negative!");
            }

            this.FuelAmount += fuelToRefuel;

            if (this.FuelAmount > this.FuelCapacity)
            {
                this.FuelAmount = this.FuelCapacity;
            }
        }

        public void Drive(double distance)
        {
            double fuelNeeded = (distance / 100) * this.FuelConsumption;

            if (fuelNeeded > this.FuelAmount)
            {
                throw new InvalidOperationException("You don't have enough fuel to drive!");
            }

            this.FuelAmount -= fuelNeeded;
        }
    }
}
