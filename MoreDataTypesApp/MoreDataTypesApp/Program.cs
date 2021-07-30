using System;
using System.Text;
namespace MoreDataTypesApp
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("How many apples?");
			string input = Console.ReadLine();
			//int numApples = Int32.Parse(input);
			var success = Int32.TryParse(input, out int ParsedApples);
			
			
			var myString = " c# list fundamentals ";
			Console.WriteLine(StringExcercise(myString));
			Console.WriteLine(StringBuilderExcercise(myString));
			StringInterpolation("Arthur");
			var num1 = 2;
			var num2 = 7;
			var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
			var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2,num1):0.####}";
			var fString3 = $"That will be {num2 / 3.0:C} please!";
			*/

			// Arrays
			int[] myIntArray = { 12, 23, 34, 45, 56 };
			Array.Reverse<int>(myIntArray);
			foreach (var element in myIntArray)
			{
				Console.WriteLine(element);
			}
			MultiDArrays();
			JaggeredArrays();
		}
		public static void MultiDArrays()
		{
			int[,] grid = new int[2, 4];
			grid[0, 1] = 6;
			grid[1, 0] = 8;
			grid[1, 3] = 10;

			char[,] gridTwo = { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' }, { 'g', 'h' } };
			Console.WriteLine("All of grid two");
			foreach (var element in gridTwo)
			{
				Console.WriteLine($"{element}");
			}
			for (int i = gridTwo.GetLowerBound(0); i <= gridTwo.GetUpperBound(0); i++)
			{
				for (int j = gridTwo.GetLowerBound(1); j <= gridTwo.GetUpperBound(1); j++)
				{
					Console.WriteLine($"({i},{j}) {gridTwo[i,j]} ");

				}
				Console.WriteLine();

			}


		}
		public static void JaggeredArrays()
		{
			int[][] intJarray = new int[2][];
			intJarray[0] = new int[4];
			intJarray[1] = new int[2];

			intJarray[0][2]= 3;
			intJarray[1][0]= 5;
			
			string[][] animalArray = new string[][]
			{
				new string[] { "llama", "puma" ,"horse", "kitten" },
				new string[] { "haddock", "tuna" }
			};
			Console.WriteLine("Jagged array animals");
			foreach (var row in animalArray)
			{
				foreach (var entry in row)
				{
					Console.WriteLine($"{entry}");
				}
			}
		}
		public static void StringInterpolation(string str)
		{
			Console.WriteLine("My name is : " +str + " using +");
			Console.WriteLine($"My name is : {str} using interpolation");
		}
		public static string StringBuilderExcercise(string myString)
		{
			var trimmedUpperString = myString.Trim().ToUpper();
			var nPos = trimmedUpperString.IndexOf('N');
			StringBuilder sb = new StringBuilder(trimmedUpperString);
			sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
			return sb.ToString();
		}
		public static string StringExcercise(string myString)
		{
			var s1 = myString.Trim().ToUpper().Replace("L","*").Replace("T", "*");
			int index = s1.IndexOf('N');
			var finalString = s1.Remove(index + 1);
			return finalString;

		}
	}
}
