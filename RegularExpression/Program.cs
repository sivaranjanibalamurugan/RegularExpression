using System;
using System.IO;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to regular expression!");
            Pincode pincode = new Pincode();
            string[] pinCodes = { "400 088", "44448888" };
            for (int i = 0; i < pinCodes.Length; i++)
            {
                pincode.CheckPin(pinCodes[i]);
            }
        }
    }
}
