using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
			KilometersToMiles();
			ReminderOfDivision();
			Console.ReadLine();
		}

		static void KilometersToMiles() 
		{
			Console.WriteLine("Enter 'km' if you want to convert to km OR enter 'mile' if you want to convert to miles: ");
			string input = Console.ReadLine();

			Console.WriteLine("Now enter the value you wanna convert: ");
			double numberInput = Convert.ToDouble(Console.ReadLine());

			switch (input) 
			{
				case "km": 
					Console.WriteLine("Its " + numberInput * 0.62 + " km");
					break;
				case "mile":
					Console.WriteLine("Its " + numberInput * 0.62 + " miles");
					break;
				default:
					Console.WriteLine("Error: Please enter km or mile ONLY");
					break;
			}

			//if (input == "km")
			//{
			//	Console.WriteLine("Its " + numberInput * 0.62 + " miles");
			//}
			//else if (input == "mile")
			//{
			//	Console.WriteLine("Its " + numberInput / 0.62 + " km");
			//}
			//else
			//{
			//	Console.WriteLine("Error: Please enter km or mile ONLY");
			//}
		
		}

		static void ReminderOfDivision() 
		{
			Console.WriteLine("Enter the first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			int mod = number1 % number2;
			Console.WriteLine("Reminder is: " + mod);
				
		}

    }
}
