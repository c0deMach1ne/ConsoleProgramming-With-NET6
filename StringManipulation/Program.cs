// See https://aka.ms/new-console-template for more information
string firstName = "Gökhan";
string lastName = "Zengin";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + firstName + " " + lastName);
Console.WriteLine($"My full name is {firstName} {lastName}");
Console.WriteLine("My full name is {0} {1}", firstName, lastName);

// String length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");

// Replace string parts
string newName = firstName.Replace('G', 'Y');
Console.WriteLine($"Your new name is {newName}");

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");

// Split String
string[] splitName = fullName.Split('n');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string emptyString = ""; // string.Empty;
string whiteSpaceString = " ";

// Compare String
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}

if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int comparisionResult = string.Compare(firstName, lastName);
if (comparisionResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

// Convert to String
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 123456789.ToString();

fullName.ToUpper();
fullName.ToLower();