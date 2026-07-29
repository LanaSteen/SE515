using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core
{
	public static class ColloringConsole
	{

		public static void Warning(string message)
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		public static void Error(string message)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		public static void Success(string message)
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
