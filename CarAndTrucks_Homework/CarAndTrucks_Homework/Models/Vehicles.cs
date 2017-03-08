using System;
namespace CarAndTrucks_Homework
{
	public abstract class Vehicles
	{
		public string LicencePlate { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string Color { get; set; }
		public double Power { get; set; }


		public virtual void PrintInfo()
		{
			Console.WriteLine($@"
Licence plates: {LicencePlate},
Make: {Make},
Model: {Model},
Year: {Year},
Color: {Color},
Power: {Power} KW");
		}
	}
}
