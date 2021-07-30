using System;

namespace MoreDataTypesApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var myString = " c# list fundamentals ";
			Console.WriteLine(StringExcercise(myString));
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
