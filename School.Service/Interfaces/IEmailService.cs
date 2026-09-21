using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Interfaces
{
	public interface IEmailService
	{
		void SendEmail(string to, string subject, string body);
	}
}
