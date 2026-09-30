//Part 1: The name
//adding !; fixes the orange error marker
System.Console.WriteLine("What is your name? ");
string fullName = Console.ReadLine()!;
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);


System.Console.WriteLine("What is your username? ");
string userName = Console.ReadLine()!;

System.Console.WriteLine("What are your initials? ");
string initials = Console.ReadLine()!;

System.Console.WriteLine("How many letters are in your last name? ");
int lastNameLetters = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {initials.ToUpper()}");
System.Console.WriteLine($"Letters in last name: {lastNameLetters}");

//Part 2

