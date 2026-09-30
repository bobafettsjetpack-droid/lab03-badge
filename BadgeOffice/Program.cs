/*
Name: Aaron Robinson
Course: CSCI1250, Section 001
Assignment: Lab 03, The Badge Office
Date: September 30, 2026
Description: Builds a student badge from a name, two random assignments, and the walking distance to a first class.
*/

//Part 1: The name
//adding !; fixes the orange error marker (I don't know why it does, I just wanted the lines gone)
using System.Data.Common;

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

int lastNameLetters = lastName.Length;

System.Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {initials.ToUpper()}");
System.Console.WriteLine($"Letters in last name: {lastNameLetters}");

//Part 2

Random rng = new Random();

int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine($"\nStudent ID: {Convert.ToString(studentId)}");
System.Console.WriteLine($"Locker: {Convert.ToString(lockerNumber)}");

//Part 3

System.Console.WriteLine("\nWhat is your dorm's X location? ");
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

double totalSec = distRound / walkingSpeed;

double timeMin = totalSec / 60;
timeMin = Math.Round(timeMin, 0);

double timeSec = totalSec % 60;
timeSec = Math.Round(timeSec, 0);

System.Console.WriteLine($"Walk time: {Convert.ToString(timeMin)} minutes {Convert.ToString(timeSec)} seconds");

//Part 4

System.Console.WriteLine("==================================\n");
System.Console.WriteLine($"{"ETSU STUDENT BADGE".PadLeft(26)}\n"); //padding works by starting from the beginning, not the end of words
System.Console.WriteLine("==================================\n");

//text.PadRight(width)

System.Console.WriteLine($"{"NAME".PadRight(10)}{fullName.ToUpper()}");
System.Console.WriteLine($"{"USERNAME".PadRight(10)}{userName}");
System.Console.WriteLine($"{"ID".PadRight(10)}{studentId}-{lastNameLetters}");
System.Console.WriteLine($"{"LOCKER".PadRight(10)}{lockerNumber.ToString()}");
System.Console.WriteLine($"{"Walk".PadRight(10)}{timeMin.ToString()} min {timeSec.ToString()} sec");
System.Console.WriteLine("\n==================================");
