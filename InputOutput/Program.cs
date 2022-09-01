// See https://aka.ms/new-console-template for more information

// Declare Variable - a storage space in memory for the time an application is running
/*
 * Data Types
 * string - Words/Numbers (Name, license plate number) - "Trevoir", "34 CM 1992"
 * int - whole numbers | double/float - decimals
 * char - One character ('A', '7', '%')
 */

string fullName; // camelCase
//string HelloWorld; // PascalCase

// Allow user input and store in variable
Console.WriteLine("Enter your full name: ");
fullName = Console.ReadLine();

// Print contents of variable/user's input
Console.WriteLine("Your full name is: " + fullName);