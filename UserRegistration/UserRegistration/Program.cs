using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Enter the password to create");
string password = Console.ReadLine();
patterns.Validation(password);