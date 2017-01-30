using System;

namespace CreaterTwoValues
{
	class MainClass
	{
		public static void Main()
		{
			var type = Console.ReadLine();

			if (type == "int")
			{
				int firstValue = int.Parse(Console.ReadLine());
				int secondValue = int.Parse(Console.ReadLine());

				Console.WriteLine(GetMax(firstValue, secondValue));
				return;
			}
			else if (type == "char")
			{
				char firstValue = char.Parse(Console.ReadLine());
				char secondValue = char.Parse(Console.ReadLine());

				Console.WriteLine(GetMax(firstValue, secondValue));
				return;

			}
			else
			{
				var firstValue = Console.ReadLine();
				var secondValue = Console.ReadLine();

				Console.WriteLine(GetMax(firstValue, secondValue));
				return;
			}


		}

		public static int GetMax(int firstVal, int secondVal)
		{
			return Math.Max(firstVal, secondVal);
		}

		public static char GetMax(char firstVal, char secondVal)
		{
			return (char)GetMax((int)firstVal, (int)secondVal);
		}

		public static string GetMax(string firstVal, string secondVal)
		{
			if (firstVal.CompareTo(secondVal) < 0)
			{
				return secondVal;
			}
			else
			{
				return firstVal;
			}
		}

	}
}
