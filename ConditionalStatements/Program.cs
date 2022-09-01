// See https://aka.ms/new-console-template for more information

Console.Write("Enter apple amount: ");
int appleAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter banana amount: ");
int bananaAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter statement type (if, switch, ternary): ");
string statementType = Console.ReadLine();

if (statementType == "if")
{

    // If Statements ( ==, <, >, <=, >=, != )
    if (appleAmount > bananaAmount)
    {
        Console.WriteLine("You have more apples");
    }
    else if (appleAmount < bananaAmount)
    {
        Console.WriteLine("You have more bananas");
    }
    else if (appleAmount == bananaAmount)
    {
        Console.WriteLine("You have the same amount of apples and bananas");
    }
}
else if (statementType == "switch")
{
    Console.Write("Enter grade (0-100): ");
    int grade = Convert.ToInt32(Console.ReadLine());
    // Switch Statements
    switch (grade)
    {
        case int n when n >= 0 && n <= 59: // between 0 and 59
            Console.WriteLine("You failed.");
            break;
        case int n when n >= 60 && n <= 100: // between 60 and 100
            Console.WriteLine("You passed.");
            break;
        case 101:
            Console.WriteLine("Single case example.");
            break;
        default:
            Console.WriteLine("Invalid grade.");
            break;
    }
}
else if (statementType == "ternary")
{
    // Ternary Operator
    var message = appleAmount > bananaAmount ? "You have more apples." : "You have more bananas.";
    Console.WriteLine(message);
}