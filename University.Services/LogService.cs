using System;
using System.Collections.Generic;
using System.Text;
using University.Core.Interfaces;

namespace University.Services
{
	public class LogService
	{

		private readonly ILogRepository _logRepository;

		public LogService(ILogRepository logRepository)
		{
			_logRepository = logRepository;
		}


		public void Log(string message)
		{
			if (String.IsNullOrEmpty(message))
			{
				return;
			}
			_logRepository.Log(message);
		}


		public int GetLogCount()
		{
			return _logRepository.GetLogCount();
		}


		public void ClearLogBackup()
		{

			_logRepository.ClearLogBackup();
			Console.WriteLine("logs cleared");
		}

	}
}
