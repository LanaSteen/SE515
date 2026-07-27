using System.Drawing;

namespace Lecture25
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			#region Thread
			//Thread thread1 = new Thread(() => 
			//{
			//	for (int i = 0; i < 10; i++)
			//	{
			//		Thread.Sleep(1000);
			//		Console.WriteLine($"Thread {i}");
			//	}

			//});


			//thread1.Start();
			//Thread.Sleep(5000); // Main thread sleeps for 5 seconds
			////thread1.Abort();  //  აღარ გამოიყენება და ამის შემცვლელი არის cancelationToken
			//thread1.Join(); // Wait for thread1 to finish before continuing



			//Console.WriteLine("Main Thread finished");
			#endregion
			#region parallel programming
			//bool isCounting = true;


			//int count1 = 0;
			//int count2 = 0;


			//Thread th1 = new Thread(() => 
			//{
			//	while (isCounting)
			//	{
			//		count1++;
			//	}
			//});
			//Thread th2 = new Thread(() => 
			//{

			//	while (isCounting)
			//	{
			//		count2++;
			//	}

			//});

			//th1.Priority = ThreadPriority.Highest;
			//th2.Priority = ThreadPriority.Lowest;

			//th1.Start();
			//th2.Start();
			//Thread.Sleep(5000);
			//isCounting = false;

			//th1.Join();
			//th2.Join();

			//Console.WriteLine(count1);
			//Console.WriteLine(count2);

			#endregion

			#region task

			//Thread thread4 = new Thread(async () =>
			//{
			//	Task.Delay(1000).Wait();
			//	await Print();
			//});

			//Thread thread3 = new Thread(async () =>
			// {
			//	 var x = await Sum(5, 10);
			//	 Console.WriteLine(x);
			// });
			//thread4.Priority = ThreadPriority.Highest;
			//thread4.Priority = ThreadPriority.Lowest;

			//thread3.Start();
			//thread4.Start();
			//Thread.Sleep(5000);
			//thread3.Join();
			//thread4.Join();
			#endregion
		}



		static async Task Print()
		{
			Console.WriteLine("hi");
		}


		static async Task<int> Sum(int a, int b)
		{

			return a+b;
		}

		static async Task<string> Greeting(string message)
		{

			return message;
		}


		static async Task<int[]> CollectionWhere(int[] nums)
		{

			return nums;
		}

		static async Task<List<string>> CollectionList(List<string> names)
		{

			return names;
		}

		static async Task<List<User>> CollectionList(List<User> names)
		{
			return names;
		}

		static async Task<IEnumerable<User>> CollectionList(IEnumerable<User> names)
		{
			return names;
		}
	}
}
