using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Enter the First name");
string n = Console.ReadLine();
if (patterns.Validation(n))
    Console.WriteLine("Valid first name");
else
    Console.WriteLine("Invalid first name");