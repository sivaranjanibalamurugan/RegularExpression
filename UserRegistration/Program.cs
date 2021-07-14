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
            Console.Write("enter First name:");
            string LasFirstName = Console.ReadLine();
            Console.Write("First name ");
            user.CheckName("firstName");
            Console.Write("enter Last name:");
            string LastName = Console.ReadLine();
            Console.Write("Last name ");
            user.CheckName(LastName);
            Console.WriteLine("Enter mail");
           string email= Console.ReadLine();
            user.EmailCheck("email");
        }
    }
}
