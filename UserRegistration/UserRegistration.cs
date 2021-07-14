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
            string pattern = @"^[a-zA-Z]{3}([\- \+ _\.][a-zA-Z0-9])*@[a-zA-Z]+\.[a-z]{2,3}";
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

    }
}
