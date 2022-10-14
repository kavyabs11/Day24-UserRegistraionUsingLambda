using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Patterns
    {
        public static string phonenumber = "^91([ ])?[6-9]{1}[0-9]{9}$";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, phonenumber))
                Console.WriteLine("Valid phone number");
            else
                Console.WriteLine("Invalid phone number");
        }
    }
}
