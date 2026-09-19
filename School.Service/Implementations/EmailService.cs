using School.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace School.Service.Implementations
{
	public class EmailService : IEmailService	
	{



		public static void SendEmail(string to, string subject, string body)
		{


			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new System.Net.NetworkCredential("stepacc210@gmail.com", "pxzx laak iyop lzzl");

			MailMessage message = new MailMessage();
			message.From = new MailAddress("stepacc210@gmail.com");  // todo hide sender
			
			message.To.Add(to);
			message.Subject = subject;
			message.Body = body;
			message.IsBodyHtml = true;

			client.Send(message);

		}

	}
}


//s m t p  
	//http
	//ftp