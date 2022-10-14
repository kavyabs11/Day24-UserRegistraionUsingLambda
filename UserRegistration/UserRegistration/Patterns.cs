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
        public static string password = "[a-z]{8}";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, password))
                Console.WriteLine("Valid password");
            else
                Console.WriteLine("Invalid password");
        }
    }
}
