using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace University.Services
{
	public class EmailService
	{

		public static void SendEmail(string to, string subject, string body)
		{


			SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
			smtp.UseDefaultCredentials = false;
			smtp.EnableSsl = true;
			smtp.Credentials = new System.Net.NetworkCredential("stepacc210@gmail.com", "ptok lzfo xzrj taqa");



			MailMessage message = new MailMessage();
			message.From = new MailAddress("stepacc210@gmail.com");
			message.To.Add(to);
			//message.To.Add("stepacc210@gmail.com");
			message.Subject = subject;
			message.Body = body;


			smtp.Send(message);
		}

	}
}


//Smtp 
//http   - https
//ftp
