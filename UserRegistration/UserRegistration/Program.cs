using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Enter the Last name");
string lastname = Console.ReadLine();
patterns.Validation(lastname);