using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Interfaces;

namespace University.Infrastructure.Repositories
{
	public class LogRepository : ILogRepository
	{
		private readonly string _path = @"C:\Users\l4nst\Desktop\SE515\University.Infrastructure\Data\log.txt";

		
		public void Log(string message)
		{
			var logMessage = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]: {message}";


			//File.AppendAllText(_path, logMessage + Environment.NewLine);



			//StreamWriter

			using (StreamWriter writer = new StreamWriter(_path, true))
			{
				writer.WriteLine(logMessage);
			}


		



			//writer.Close();

			//writer.Dispose();

			//StreamReader


			//Dispose
			//close

		}

		public int GetLogCount()
		{
			int count =0;
			if (File.Exists(_path))
			{
				using(StreamReader reader = new StreamReader(_path))
				{
					string line;
					while( (line = reader.ReadLine()) != null)
					{
						count++;
						
						Console.WriteLine(line);
					}
				}
			}

			return count;
			
		}


		public void ClearLogBackup()
		{
			File.Move(_path, @"C:\Users\l4nst\Desktop\backup\logBackup.txt");

		}


	}
}
