// See https://aka.ms/new-console-template for more information

// Declare
List<string> names = new List<string>();
string name = string.Empty;

// Add values to list
names.Add("Gökhan");
names.Add("Hande");
names.Add("c0deMach1ne");

// Remove values to list
names.Remove("c0deMach1ne");

Console.WriteLine("Enter Names");
//while (name != "-1")
//while (name.Equals("-1") == false)
while (!name.Equals("-1"))
{
    Console.WriteLine("Enter Name: ");
    name = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}

// Print values in List
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via foreach loop");
foreach (string itemName in names)
{
    Console.WriteLine(itemName);
}