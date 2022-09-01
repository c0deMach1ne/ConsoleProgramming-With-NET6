// See https://aka.ms/new-console-template for more information

// Variable Declarations and Types
string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

// Prompt User for Input
Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working?: ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine("Your name is: " + fullName); // Concatenation
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}"); // Interpolation
Console.WriteLine($"Your gender is: {gender}"); // Interpolation
Console.WriteLine($"You are empyloyed: {working}"); // Interpolation