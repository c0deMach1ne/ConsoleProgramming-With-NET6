// See https://aka.ms/new-console-template for more information

// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1992, 05, 29);
Console.WriteLine("My Dob is: " + dateOfBirth);
Console.WriteLine("My Dob is: " + dateOfBirth.Date);

Console.WriteLine("Day of Week: {0}", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of Year: {0}", dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day: {0}", dateOfBirth.TimeOfDay);
Console.WriteLine("Tick: {0}", dateOfBirth.Ticks);
Console.WriteLine("Kind: {0}", dateOfBirth.Kind);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is: " + now);

// Create a DateTime from a string
DateTime dateFromString = DateTime.Parse("01/09/2022", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is: " + dateFromString);

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnlyNow = TimeOnly.FromDateTime(now);
Console.WriteLine("Time Only: " + timeOnlyNow);

