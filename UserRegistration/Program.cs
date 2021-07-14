using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");
            UserRegistration user = new UserRegistration();
            
            Console.Write("enter First name:");
            string LasFirstName = Console.ReadLine();
            Console.Write("First name ");
            user.CheckName("first Name");
            Console.Write("enter Last name:");
            string LastName = Console.ReadLine();
            Console.Write("Last name ");
            user.CheckName(LastName);
            Console.WriteLine("Enter mail");
            string mail = Console.ReadLine();
            user.EmailCheck("mail");
            Console.WriteLine("Enter  Mobile number");
            string number = Console.ReadLine();
            user.CheckMobileNumber("number");
        }
    }
}
