using UserRegistration;

Console.WriteLine("Welcome to User Registration program using Regex patterns");
Patterns patterns = new Patterns();
Console.WriteLine("Checking the sample email address");
string email1 = "abc@yahoo.com"; //valid
patterns.Validation(email1);
string email2 = "abc-100@yahoo.com"; //valid
patterns.Validation(email2);
string email3 = "abc.100@yahoo.com"; //valid
patterns.Validation(email3);
string email4 = "abc111@abc.com"; //valid
patterns.Validation(email4);
string email5 = "abc-100@abc.net"; //valid
patterns.Validation(email5);
string email6 = "abc.100@abc.com.au"; //valid
patterns.Validation(email6);
string email7 = "abc@1.com"; //invalid
patterns.Validation(email7);
string email8 = "abc@gmail.com.com"; //valid
patterns.Validation(email8);
string email9 = "abc+100@gmail.com"; //valid
patterns.Validation(email9);