namespace Thread_Task
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			#region Thread

			//Thread.CurrentThread.Name = "Main Thread";


			//Console.WriteLine("Main Thread: {0}", Thread.CurrentThread.Name);
			//Console.WriteLine("Main Thread ID: {0}", Thread.CurrentThread.ManagedThreadId);


			//Thread thread1 = new Thread(() => 
			//{ 
			//	Thread.CurrentThread.Name = "Thread 1"; 
			//	Console.WriteLine("Thread 1: {0}", Thread.CurrentThread.Name); 
			//	Console.WriteLine("Thread 1 ID: {0}", Thread.CurrentThread.ManagedThreadId);
			//	Thread.Sleep(3000);
			//});


			//thread1.Start();
			//thread1.Join();



			//Thread thread2 = new Thread(PrintInThred);
			//thread2.Start();
			//thread2.Join();

			//int count1 = 0;
			//int count2 = 0;
			//bool isThread1Running = true;

			//Thread t1 = new Thread(() =>
			//{

			//	while (isThread1Running) 
			//	{
			//		count1++;
			//	}
			//});

			//Thread t2 = new Thread(() =>
			//{
			//	while (isThread1Running)
			//	{
			//		count2++;
			//	}
			//});

			//t1.Priority = ThreadPriority.Lowest;
			//t2.Priority = ThreadPriority.Highest;

			//t1.Start();
			//t2.Start();


			//Thread.Sleep(3000);

			//isThread1Running = false;

			//t1.Join();
			//t2.Join();



			//Console.WriteLine("count1: {0}", count1);
			//Console.WriteLine("count2: {0}", count2);
			//Console.WriteLine("Main ended");


			#endregion



			await Print();
		}



		static async Task Print()
		{
			Console.WriteLine("Hello");
		}



		//async Task = void


		//static void PrintInThred()
		//{
		//	for (int i = 0; i < 5; i++)
		//	{
		//		Console.WriteLine(i);
		//		Thread.Sleep(1000);
		//	}
		//}



	}
}
