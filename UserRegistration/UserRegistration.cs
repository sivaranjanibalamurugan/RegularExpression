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
    }
}
