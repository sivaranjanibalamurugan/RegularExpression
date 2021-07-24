using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            UserRegistration user = new UserRegistration();
            Console.Write("enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("First name ");
            user.CheckName(firstName);
            Console.Write("enter last name:");
            string lastName = Console.ReadLine();
            Console.Write("Last name ");
            user.CheckName(lastName);
            Console.Write("enter email:");
            string email = Console.ReadLine();
            user.EmailCheck(email);
            Console.Write("enter mobile number:");
            string number = Console.ReadLine();
            user.CheckMobileNumber(number);
            Console.Write("enter password:");
            string password = Console.ReadLine();
            user.CheckPassword(password);
        }
    }
}
