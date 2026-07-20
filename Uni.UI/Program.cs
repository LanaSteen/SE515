using Uni.Core;

namespace Uni.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

		    Test test = new Test();
			test.Age = 50;
			Console.WriteLine(test.Age);
		}
	}
}


//exe vs dll
//Console.app vs  Class Library (DLL)