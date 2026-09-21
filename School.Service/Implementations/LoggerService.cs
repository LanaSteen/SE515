using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace School.Service.Implementations
{
	public class LoggerService
	{
		private readonly string path = Path.GetFullPath(
	Path.Combine(
		AppContext.BaseDirectory,
		"..",
		"..",
		"..",
		"..",
		"School.Domain",
		"Logs",
		"logs.txt"
	)
);

		public void Log(string message)
		{

			var ip = GetUserIP();

			File.AppendAllText(path, $"{DateTime.Now} - {ip} - {message}\n");
		}



		private string GetUserIP()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());

			foreach (var ip in host.AddressList)
			{
				 if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}

			return null;
		}


	}
}
