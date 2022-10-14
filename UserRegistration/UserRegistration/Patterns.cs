﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Patterns
    {
        public static string email = "^[a-zA-Z0-9]+([!@#$%^&*()_+.,][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public void Validation(string sample)
        {
            if (Regex.IsMatch(sample, email))
                Console.WriteLine("Valid email address");
            else
                Console.WriteLine("Invalid email address");
        }
    }
}
