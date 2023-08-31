﻿using MailKit.Net.Smtp;
using MimeKit;

namespace IntroEmailApplication
{
  internal class Program
  {
    private const int SmtpPort = 465;
    private const bool IsSslConnection = true;

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the command line email client!");

      var loop = true;

      try
      {
      while (loop)
      {
        Console.WriteLine();
        Console.WriteLine("New Message");

        var mail = new MimeMessage();

        //Added my name and email address
        mail.From.Add(new MailboxAddress("Zi Yang Lee", "yangleev3@gmail.com")); // TODO: update to your own name and email address

                Console.Write("To: ");
        mail.To.Add(new MailboxAddress("", Console.ReadLine()));

        Console.Write("Subject: ");
        mail.Subject = Console.ReadLine();

        Console.Write("Body: ");
        mail.Body = new TextPart("plain") { Text = Console.ReadLine() };

        using (var client = new SmtpClient())
        {
          client.Connect("smtp.gmail.com", SmtpPort, IsSslConnection);
          //Added my username and app password
                    client.Authenticate("yangleev3@gmail.com", "ivegdjnrvrfzuvca"); // TODO: update to your own username and APP PASSWORD (this is different from your normal password)
                    client.Send(mail);
          client.Disconnect(true);

          Console.WriteLine("Message sent succesfully!");
        }

        Console.WriteLine();
        Console.Write("Would you like to send another email? (Y/N): ");

        if (Console.ReadKey().Key != ConsoleKey.Y)
        {
          loop = false;
        }
      }
      }
      catch (Exception ex)
      {
        Console.WriteLine("This is the ERROR!!!" + ex.Message);
      }
    }
  }
}