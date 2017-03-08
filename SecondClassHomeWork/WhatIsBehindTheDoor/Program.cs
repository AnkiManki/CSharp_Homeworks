using System;

namespace SecondClassHomeWork
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			WhatIsBehindTheDoor();
			AverageNumber();
			SwapNumbers();
			Console.ReadLine();
		}

		public static void WhatIsBehindTheDoor() 
		{
			Console.WriteLine("What is behind door number: 1, 2, 3");
			int input = Convert.ToInt32(Console.ReadLine());

			switch (input)
			{
				case 1:
					Console.WriteLine("You got a new car");
					break;
				case 2:
					Console.WriteLine("You got a new plane");
					break;
				case 3:
					Console.WriteLine("You got a new bike");
					break;
				default:
					Console.WriteLine("Please choose 1,2 or 3");
					break;
			}


		}

		public static void AverageNumber()
		{
			Console.WriteLine("Enter first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third number: ");
			int number3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter forth number: ");
			int number4 = Convert.ToInt32(Console.ReadLine());

			int result = (number1 + number2 + number3 + number4) / 4;
			Console.WriteLine("Average number is: " + result);
		}

		public static void SwapNumbers() 
		{
			Console.WriteLine("Enter first number: ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number: ");
			int number2 = Convert.ToInt32(Console.ReadLine());

			int temp1 = number1;
			int temp2 = number2;

			Console.WriteLine("The first number is: " + temp2);
			Console.WriteLine("The second number is: " + temp1);

		}
	}
}
