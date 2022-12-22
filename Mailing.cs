
/*
 


using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;
using System.Net;
namespace LearningSelenium
{
  [TestClass]
  public class Mailing
  {
    [TestMethod]
    public void SendEmail()
    {
      try
      {
        MailMessage mail = new MailMessage();
        #region DadosEmail
        string fromEmail = "email@hotmail.com";
        #region pass
        string passWord = "password";
        #endregion
        string toEmail = "email@gmail.com";
        #endregion
        string subject = "title of email";
        string contentBody = "<p>text in the body of the mail</p>";

        mail.From = new MailAddress(fromEmail);
        mail.To.Add(toEmail);
        mail.Subject = subject;
        mail.Body = contentBody;
        mail.IsBodyHtml = true;
        //mail.Attachments.Add(new Attachment(@"C:/Users/"+Environment.Username+"/source/repos/LearningSelenium/screenshot.png"));

        SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
        smtp.Credentials = new NetworkCredential(fromEmail, passWord);
        smtp.EnableSsl = true;
     
        smtp.Send(mail);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.StackTrace);
      }
      finally
      {
        Console.WriteLine("finally");

      }
    }
  }
}

*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Org.BouncyCastle.Crypto.Macs;

namespace LearningSelenium
{
  [TestClass]
  public class Mailing
  {
    [TestMethod]
    public void SendEmail()
    {
      var message = new MimeMessage();
      message.From.Add(new MailboxAddress("name surname", "email@hotmail.com"));
      message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "email@gmail.com"));
      message.Subject = "How you doin'?";

      message.Body = new TextPart("plain")
      {
        Text = @"Hey Chandler Bing,

I just wanted to let you know that Monica and I were going to go play some paintball, you in?

-- Joey"
      };

      using (var client = new SmtpClient())
      {
        client.Connect("smtp.office365.com", 587, false);
//        1 Gmail smtp.gmail.com  587
//2 Outlook smtp.live.com  587
//3 Yahoo Mail smtp.mail.yahoo.com 465
//4 Yahoo Mail Plus plus.smtp.mail.yahoo.com 465
//5 Hotmail smtp.live.com  465
//6 Office365.com smtp.office365.com 587
//7 zoho Mail smtp.zoho.com  465
        // Note: only needed if the SMTP server requires authentication
        client.Authenticate("email@hotmail.com", "password");

        client.Send(message);
        client.Disconnect(true);
      }
    }
  }
}