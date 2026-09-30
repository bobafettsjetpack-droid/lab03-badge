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

Random rng = new Random();

int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine($"Student ID: {Convert.ToString(studentId)}");
System.Console.WriteLine($"Locker: {Convert.ToString(lockerNumber)}");

//Part 3

System.Console.WriteLine("What is your dorm's X location? ");
double dormX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("What is your dorm's Y location? ");
double dormY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("What is your class's X location? ");
double classX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("What is your class's Y location? ");
double classY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("What is your walking speed in feet per second? ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((classX - dormX), 2) + Math.Pow((classY - dormY), 2));
distance = Math.Round(distance, 1);

System.Console.WriteLine($"Distance: {Convert.ToString(distance)} feet");

double distRound = Math.Round(distance, 0);

double timeMin = distRound / 60;
timeMin = Math.Round(timeMin, 0);

double timeSec = distRound % 60;
timeSec = Math.Round(distRound, 0);

System.Console.WriteLine($"Walk time: {Convert.ToString(timeMin)} minutes {Convert.ToString(timeSec)} seconds");


