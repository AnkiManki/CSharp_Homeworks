using System;

namespace CarAndTrucks_Homework
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			bool displayMenu = true;
			while (displayMenu)
			{
				displayMenu = MainMenu();
			}

			Console.ReadLine();
		}

		public static bool MainMenu() 
		{
			Console.WriteLine("====================");
			Console.WriteLine("Choose an option: ");
			Console.WriteLine("1) Create new car");
			Console.WriteLine("2) Create new truck");
			Console.WriteLine("3) Exit");
			Console.WriteLine("====================");

			string result = Console.ReadLine();

			switch (result)
			{
				case "1":
					CreateCar();
					return true;
				case "2":
					CreateTruck();
					return true;
				case "3":
					return false;
				default:
					Console.WriteLine("Invalid input!");
					Console.WriteLine("");
					return true;
			}
		}


		public static void CreateCar() 
		{
			Console.Clear();

			var car = new Car();

			Console.WriteLine("Create new car!");
			Console.Write("Insert licence plate number: ");

			string result = Console.ReadLine();

			if (result.Length < 6 || result.Length > 7)
			{
				Console.WriteLine("Invalid licence plate!");
				MainMenu();
				return;
			}
			else 
				car.LicencePlate = result;
			

			Console.Write("Insert make: ");
			car.Make = Console.ReadLine();

			Console.Write("Insert model: ");
			car.Model = Console.ReadLine();

			Console.Write("Insert year: ");

			car.Year = Console.ReadLine();

			Console.Write("Insert color: ");
			car.Color = Console.ReadLine();

			Console.Write("Insert power: ");
			car.Power = double.Parse(Console.ReadLine());

			Console.WriteLine("=======================");

			car.PrintInfo();
		}

		public static void CreateTruck() 
		{
			Console.Clear();

			var truck = new Truck();

			Console.WriteLine("Create new truck!");
			Console.Write("Insert licence plate number: ");

			string result = Console.ReadLine();

			if (result.Length < 6 || result.Length > 7)
			{
				Console.WriteLine("Invalid licence plate!");
				MainMenu();
				return;
			}
			else
				truck.LicencePlate = result;

			Console.Write("Insert make: ");
			truck.Make = Console.ReadLine();

			Console.Write("Insert model: ");
			truck.Model = Console.ReadLine();

			Console.Write("Insert year: ");
			truck.Year = Console.ReadLine();

			Console.Write("Insert color: ");
			truck.Color = Console.ReadLine();

			Console.Write("Insert power: ");
			truck.Power = double.Parse(Console.ReadLine());

			Console.Write("Insert capacity: ");
			truck.Capacity = double.Parse(Console.ReadLine());

			Console.WriteLine("=======================");

			truck.PrintInfo();
		}


	}
}
