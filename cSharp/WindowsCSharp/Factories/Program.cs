using FactoryPattern;
using static System.Console;


String? inputFromConsole = null;

WriteLine("Enter the vehicle Type");
inputFromConsole = ReadLine();

IVehicle Type = VehicleFactory.GetVehicle(inputFromConsole);
WriteLine("Type is " + Type.VehicleType());
WriteLine("Number of Wheel is " + Type.NumberOfWheels());
ReadKey();
