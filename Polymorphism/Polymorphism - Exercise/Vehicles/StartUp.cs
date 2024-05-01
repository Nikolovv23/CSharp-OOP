// Create a program that models 2 vehicles (a Car and a Truck) and simulates driving and refueling them.
// Car and truck both have fuel quantity, fuel consumption in liters per km, and can be driven a given distance and refueled with a given amount of fuel.
// It's summer, so both vehicles use air conditioners and their fuel consumption per km is increased by 0.9 liters for the car and with 1.6 liters for the truck.
// Also, the truck has a tiny hole in its tank and when it’s refueled it keeps only 95% of the given fuel.
// The car has no problems and adds all the given fuel to its tank. If a vehicle cannot travel the given distance, its fuel does not change.
// Input
// •	On the first line – information about the car in the format: "Car {fuel quantity} {liters per km}"
// •	On the second line – info about the truck in the format: "Truck {fuel quantity} {liters per km}"
// •	On the third line – the number of commands N that will be given on the next N lines
// •	On the next N lines – commands in the format:
// 	"Drive Car {distance}"
// 	"Drive Truck {distance}"
// 	"Refuel Car {liters}"
// 	"Refuel Truck {liters}"
// Output
// •	After each Drive command, if there was enough fuel, print on the console a message in the format:
// 	"Car/Truck travelled {distance} km"
// •	If there was not enough fuel, print: "Car/Truck needs refueling"
// •	After the last command, print the remaining fuel for both the car and the truck, rounded to 2 digits after the floating point in the format:
// 	"Car: {liters}"
// 	"Truck: {liters}"

//      Input:
// Car 15 0.3
// Truck 100 0.9
// 4
// Drive Car 9
// Drive Car 30
// Refuel Car 50
// Drive Truck 10
//      Output:
// Car travelled 9 km
// Car needs refueling
// Truck travelled 10 km
// Car: 54.20
// Truck: 75.00



namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));
            string[] truckData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                try
                {
                    string[] data = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (data[0] == "Drive")
                    {
                        switch (data[1])
                        {
                            case "Car":
                                car.Drive(double.Parse(data[2]));
                                break;
                            case "Truck":
                                truck.Drive(double.Parse(data[2]));
                                break;
                        }
                    }
                    else if (data[0] == "Refuel")
                    {
                        switch (data[1])
                        {
                            case "Car":
                                car.Refuel(double.Parse(data[2]));
                                break;
                            case "Truck":
                                truck.Refuel(double.Parse(data[2]));
                                break;
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
