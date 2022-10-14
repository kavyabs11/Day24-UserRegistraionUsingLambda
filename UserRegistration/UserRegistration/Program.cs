using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Enter the phone number");
string phonenumber = Console.ReadLine();
patterns.Validation(phonenumber); 