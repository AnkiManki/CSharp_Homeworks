using System;
namespace CarAndTrucks_Homework
{
	public class Truck : Vehicles
	{
		public double Capacity { get; set; }


		public override void PrintInfo()
		{
			Console.WriteLine($@"
Licence plates: {LicencePlate}, 
Make: {Make}, 
Model: {Model}, 
Year: {Year}, 
Color: {Color}, 
Power: {Power}, 
Capacity: {Capacity}");
		}


	}
}
