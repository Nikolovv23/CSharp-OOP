// Use your solution of the "Vehicles" task for the starting point and add more functionality. Add a new vehicle – Bus.
// Add to every vehicle a new property – tank capacity. A vehicle cannot start with or refuel above its tank capacity.
// If you try to put more fuel in the tank than the available space, print on the console "Cannot fit {fuel amount} fuel in the tank"
// and do not add any fuel in the vehicle’s tank. If you try to create a vehicle with more fuel than its tank capacity, create it but start with an empty tank.
// Add a new command for the bus. You can drive the bus with or without people.With people,
// the air - conditioner is turned on and its fuel consumption per kilometer is increased by 1.4 liters.
// If there are no people on the bus, the air - conditioner is turned off and does not increase the fuel consumption.
// Finally, add validation for the amount of fuel given to the Refuel command – if it is 0 or negative, print "Fuel must be a positive number".
// Input
// •	On the first three lines you will receive information about the vehicles in the format:
// 	"Vehicle {initial fuel quantity} {liters per km} {tank capacity}"
// •	On the fourth line - the number of commands N that will be given on the next N lines
// •	On the next N lines - commands in format:
// 	"Drive Car {distance}"
// 	"Drive Truck {distance}"
// 	"Drive Bus {distance}"
// 	"DriveEmpty Bus {distance}"
// 	"Refuel Car {liters}"
// 	"Refuel Truck {liters}"
// 	"Refuel Bus {liters}"
// Output
// •	After each Drive command, if there was enough fuel, print on the console a message in the format:
// 	"Car/Truck travelled {distance} km"
// •	If there was not enough fuel, print:
// 	"Car/Truck needs refueling"
// •	If you try to refuel with an amount ≤ 0 print:
// 	"Fuel must be a positive number"
// •	If the given fuel cannot fit in the tank, print:
// 	"Cannot fit {fuel amount} fuel in the tank"
// •	After the "End" command, print the remaining fuel for all vehicles, rounded to 2 digits after the floating point in the format:
// 	"Car: {liters}"
// 	"Truck: {liters}"
// 	"Bus: {liters}"

//      Input:
// Car 30 0.04 70
// Truck 100 0.5 300
// Bus 40 0.3 150
// 8
// Refuel Car -10
// Refuel Truck 0
// Refuel Car 10
// Refuel Car 300
// Drive Bus 10
// Refuel Bus 1000
// DriveEmpty Bus 100
// Refuel Truck 1000  
//      Output:
// Fuel must be a positive number
// Fuel must be a positive number
// Cannot fit 300 fuel in the tank
// Bus travelled 10 km
// Cannot fit 1000 fuel in the tank
// Bus needs refueling
// Cannot fit 1000 fuel in the tank
// Car: 40.00
// Truck: 100.00
// Bus: 23.00


namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(carData[3]),
                double.Parse(carData[2]) , double.Parse(carData[1]));
            string[] truckData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(truckData[3]),
                double.Parse(truckData[2]), double.Parse(truckData[1]));
            string[] busData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Bus bus = new Bus(double.Parse(busData[3]),
                double.Parse(busData[2]), double.Parse(busData[1]));

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
                            case "Bus":
                                bus.DriveWithPeople(double.Parse(data[2]));
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
                            case "Bus":
                                bus.Refuel(double.Parse(data[2]));
                                break;
                        }
                    }
                    else
                    {
                        bus.Drive(double.Parse(data[2]));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

        }
    }
}
