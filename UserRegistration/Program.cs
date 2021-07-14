using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            UserRegistration user = new UserRegistration();
            Console.WriteLine("User registration");
            Console.Write("enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("First name ");
            user.CheckName(firstName);
        }
    }
}
