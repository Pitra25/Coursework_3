using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;

namespace Coursework_3.Classes
{
	internal class Mail
	{
		public void SendMail(string mail, string subject, string message)
		{
			var ResultMessage = new MimeMessage();

			ResultMessage.From.Add(new MailboxAddress("Test name", "akulovivera882@gmail.com")); // С которой 
			ResultMessage.To.Add(new MailboxAddress("", mail));
			ResultMessage.Subject = subject; // тема письма
			ResultMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = message
			};

			using (var client = new SmtpClient())
			{
				client.Connect("smtp.gmail.com", 587, false); // 587 + false или 465 + true
				client.Authenticate("akulovivera882@gmail.com", "rpgl ypkr ourv oshl");
				client.Send(ResultMessage);

				client.Disconnect(true);
			}
		}
	}
}
