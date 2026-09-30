System.Console.WriteLine("What is your name? ");
string name = Console.ReadLine();

System.Console.WriteLine("What is your username? ");
string userName = Console.ReadLine();

System.Console.WriteLine("What are your initials? ");
string initials = Console.ReadLine();

System.Console.WriteLine("How many letters are in your last name? ");
int lastNameLetters = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine($"Name on badge: {name}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {initials}");
System.Console.WriteLine($"Letters in last name: {lastNameLetters}");
