using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegistration
    {
        public void CheckName(string name)
        {
            string pattern = "[A-Z][a-z]{2}[a-z]*";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                Console.WriteLine("{0} is Valid name", name);
            }
            else
            {
                Console.WriteLine("{0} is Invalid", name);
            }
        }

        public void EmailCheck(string mail)
        {
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.][a-zA-Z0-9])*@[a-zA-Z]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            {
                if (regex.IsMatch(mail))
                {
                    Console.WriteLine("{0}-->Valid", mail);
                }
                else
                {
                    Console.WriteLine("{0}-->Invalid", mail);
                }
            }
        }

        public void CheckMobileNumber(string num)
        {
            string pattern =@"^[1-9]{2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(num))
            {
                Console.WriteLine("{0} is valid", num);
            }
            else
            {
                Console.WriteLine("{0} is invalid", num);
            }
        }
        public void CheckPassword(string password)
        {
            string pattern = "^[a-zA-Z0-9]{8,16}$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(password))
            {
                Console.WriteLine("{0} is valid", password);
            }
            else
            {
                Console.WriteLine("{0} is Invalid", password);
            }
        }
    }
}
