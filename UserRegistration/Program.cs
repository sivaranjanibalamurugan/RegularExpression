using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            UserRegistration user = new UserRegistration();
           //Console.WriteLine("User registration");
            Console.Write("enter Last name:");
            string LastName = Console.ReadLine();
            Console.Write("Last name ");
            user.CheckName(LastName);
        }
    }
}
