namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private const string Make = "BMW";
                
        private const string Model = "M5";
                
        private const double FuelConsumption = 10;
                
        private const double FuelCapacity = 50;

        Car BMW;
        [SetUp] 
        public void SetUp()
        {
            BMW = new Car(Make, Model, FuelConsumption, FuelCapacity);
        }

        [Test]
        public void Constructor_CorrectParameters_CreateNEwInstance()
        {
            Car car = new Car(Make, Model, FuelConsumption, FuelCapacity);
            Assert.That(car, Is.Not.Null);
            Assert.That(car.Make, Is.EqualTo(Make));
            Assert.That(car.Model, Is.EqualTo(Model));
            Assert.That(car.FuelConsumption, Is.EqualTo(FuelConsumption));
            Assert.That(car.FuelCapacity, Is.EqualTo(FuelCapacity));
            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [Test]
        public void Make_Null_ThrowsExeption()
        {
           Exception ex = Assert.Throws<ArgumentException>(
                () => new Car(null, Model, FuelConsumption, FuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Make cannot be null or empty!"));
        }

        [Test]
        public void Make_Empty_ThrowsExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(
                 () => new Car(string.Empty, Model, FuelConsumption, FuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Make cannot be null or empty!"));
        }

        [Test]
        public void Model_Null_ThrowsExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(
                 () => new Car(Make, null, FuelConsumption, FuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Model cannot be null or empty!"));
        }

        [Test]
        public void Model_Empty_ThrowsExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(
                 () => new Car(Make, string.Empty, FuelConsumption, FuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Model cannot be null or empty!"));
        }

        [Test]
        public void FuelConsumption_ZeroOrNegative_ThrowsExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(
                 () => new Car(Make, Model, -1, FuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));

            Exception exeption = Assert.Throws<ArgumentException>(
                 () => new Car(Make, Model, 0, FuelCapacity));
            Assert.That(exeption.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

        [Test]
        public void FuelCapacity_ZeroOrNegative_ThrowsExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(
                () => new Car(Make, Model, FuelConsumption, 0));
            Assert.That(ex.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));

            Exception exeption = Assert.Throws<ArgumentException>(
                 () => new Car(Make, Model, FuelConsumption, -1));
            Assert.That(exeption.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

        [Test]
        public void Refuel_ValidPath()
        {
            BMW.Refuel(FuelCapacity);
            Assert.That(BMW.FuelAmount, Is.EqualTo(FuelCapacity)) ;
        }

        [Test]
        public void Refuel_WithFuelOverCapacity_Action()
        {
            BMW.Refuel(FuelCapacity + 10);
            Assert.That(BMW.FuelAmount, Is.EqualTo(FuelCapacity));
        }

        [Test]
        public void Refuel_WithNegativeNumber_ThrowExeption()
        {
            Exception ex = Assert.Throws<ArgumentException>(
                () => BMW.Refuel(-1));
            Assert.That(ex.Message, Is.EqualTo("Fuel amount cannot be zero or negative!"));

        }

        [Test]
        public void Drive_ValidPAth()
        {
            double distance = 300;
            BMW.Refuel(FuelCapacity);
            double fuelNeeded = (distance / 100) * FuelConsumption;
            double expectedFuelAmount = BMW.FuelAmount - fuelNeeded;

            BMW.Drive(distance);
            Assert.That(BMW.FuelAmount, Is.EqualTo(expectedFuelAmount));
        }

        [Test]
        public void Drive_FuelAmountIsNotEnough()
        {
            double distance = 300;
            double fuelNeeded = (distance / 100) * FuelConsumption;
            double expectedFuelAmount = BMW.FuelAmount - fuelNeeded;

            Exception ex = Assert.Throws<InvalidOperationException>( 
                () => BMW.Drive(distance));
            Assert.That(ex.Message, Is.EqualTo("You don't have enough fuel to drive!"));
        }

    }
}