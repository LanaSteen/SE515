using Microsoft.Extensions.Configuration;
using School.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace School.Service.Implementations
{
	public class EmailService : IEmailService
	{

		private readonly IConfiguration _configuration;


		public EmailService(IConfiguration configuration)
		{
			_configuration = configuration;
		}



		public void SendEmail(string to, string subject, string body)
		{

			var smtpserver = _configuration["EmailSerrings:Server"];
			var port = int.Parse(_configuration["EmailSerrings:Port"]);
			var sender = _configuration["EmailSerrings:Sender"];
			var password = _configuration["EmailSerrings:Password"];

			SmtpClient client = new SmtpClient(smtpserver, port);
			client.EnableSsl = true;
			client.Credentials = new System.Net.NetworkCredential(sender, password);

			MailMessage message = new MailMessage();
			message.From = new MailAddress(sender);  // todo hide sender
			
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