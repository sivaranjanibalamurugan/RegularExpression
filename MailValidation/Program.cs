using System;

namespace MailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email validation");
            EmailValidation email = new EmailValidation();
            email.EmailCheck();
            Console.Read();
        }
    }
}
