using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegularExpression
{
    public class Pincode
    {
        public void CheckPin(string pin)
        {
            string pattern = "^[1-9][0-9]{2}\\s{0,1}[0-9]{3}$";
          
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(pin))
            {
                Console.WriteLine("PinCode :{0} --> valid", pin);
            }
            else
            {
                Console.WriteLine("Pincode :{0} --> invalid", pin);
            }
        }
    }
}
