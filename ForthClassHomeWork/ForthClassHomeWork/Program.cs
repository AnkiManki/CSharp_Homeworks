using System;

namespace ForthClassHomeWork
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter the size of the array: ");
			int arrSize = int.Parse(Console.ReadLine());
			int[] integerArr = new int[arrSize];

			FillArray(integerArr);
			DisplayReverseArray(integerArr);
			EvenNumbers(integerArr);
			OddNumbers(integerArr);

			Console.ReadLine();
		}


		public static void FillArray(int[] integerArr) 
		{
			for (int i = 0; i < integerArr.Length; i++)
			{
				Console.WriteLine("Enter the value for the {0} element", i + 1);

				string inputValue = Console.ReadLine();

				if (int.TryParse(inputValue, out integerArr[i]) == false)
				{
					Console.WriteLine("Input is wrong format!");
					return;
				}
			}
		}


		public static void DisplayReverseArray(int[] integerArr)
		{
			Console.WriteLine("\nReversed elements in the array are: ");
			for (int i = integerArr.Length - 1; i >= 0; i--)
			{
				Console.Write("{0} ", integerArr[i]);
			}
		}


		public static void EvenNumbers(int[] integerArr)
		{
			Console.WriteLine("\nEven numbers in array are: ");
			for (int i = 0; i < integerArr.Length; i++)
			{
				if (integerArr[i] % 2 == 0)
				{
					Console.Write("{0} ", integerArr[i]);
				}
			}
		}


		public static void OddNumbers(int[] integerArr)
		{
			Console.WriteLine("\nOdd numbers in array are: ");
			for (int i = 0; i < integerArr.Length; i++)
			{
				if (integerArr[i] % 2 != 0)
				{
					Console.Write("{0} ", integerArr[i]);
				}
			}

		}


	}
}
