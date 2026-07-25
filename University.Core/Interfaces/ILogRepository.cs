using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Interfaces
{
	public interface ILogRepository
	{
		void Log(string message);
		int GetLogCount();
		void ClearLogBackup();
	}
}
