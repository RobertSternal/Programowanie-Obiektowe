using System;

namespace Lab2
{

    abstract class AbstractMessage
    {
        public string Content
        {
            get, init}
            abstract public void Send()
    }






    class SmsMessage : AbstractMessage
    {
        public string PhoneNumber
        {
            get, init,}
            public override void Send()
        {
            Console.WriteLine($"Sending sms to {PhoneNumber} with content {Content}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string messageType = "email";
            switch (messageType)
            {
                case "email";
                    Console.WriteLine("Wysylanie maila");
                    break;
                case "sms"
                    Console.WriteLine("Wysylanie sms");
                    break;
                case "messenger"
                    Console.WriteLine("Wysylanie powiadomienia")
                    break;
            }

            AbstractMessage[] messages = new AbstractMessage[4];
            messages[0] = new EmailMessage() { Content = "Hello", To = "adam@op.pl", from = "", Subject = "" }
            messages[1] = new EmailMessage() { Content = "Hello", To = "adam@op.pl", from = "", Subject = "" }
            messages[2] = new EmailMessage() { Content = "Hello", To = "adam@op.pl", from = "", Subject = "" }
            messages[3] = new EmailMessage() { Content = "Hello", To = "adam@op.pl", from = "", Subject = "" }

            IFly[] flyingObjects = new IFly[3];
            flyingObjects[0] = new Duck();
            flyingObjects[1] = new


        }
    }
}
