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
            string FirstName = Console.ReadLine();
            Console.Write("First name ");
            user.CheckName("first Name");
            Console.Write("enter Last name:");
            string LastName = Console.ReadLine();
            Console.Write("Last name ");
            user.CheckName(LastName);
            Console.Write("Enter your Email id:");
            string email = Console.ReadLine();
            user.EmailCheck(email);
            Console.Write("Enter your Mobile Number:");
            string num = Console.ReadLine();
            user.CheckMobileNumber(num);
            Console.Write("Enter the password:");
            string password = Console.ReadLine();
            user.CheckPassword(password);

        }
    }
}
