using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Enter the email address");
string email = Console.ReadLine();
patterns.Validation(email);