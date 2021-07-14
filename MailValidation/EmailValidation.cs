using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MailValidation
{
    class EmailValidation
    {
        public void EmailCheck()
        {
            string pattern = @"^[a-zA-Z]{3}@[a-zA-Z0-9]+";
            string[] mail = { "xyz@mail", "xyzabc8", "siv@gmail" };
            Regex regex = new Regex(pattern);
            for (int i = 0; i < mail.Length; i++)
            {
                if (regex.IsMatch(mail[i]))
                {
                    Console.WriteLine("{0}-->Valid", mail[i]);
                }
                else
                {
                    Console.WriteLine("{0}-->Invalid", mail[i]);
                }
            }

        }
    }
}
