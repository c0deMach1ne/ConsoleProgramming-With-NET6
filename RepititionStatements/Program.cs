// See https://aka.ms/new-console-template for more information

int index = 0;

Console.WriteLine("İşlem numarasını giriniz.");
Console.WriteLine("0 - for");
Console.WriteLine("1 - while");
Console.WriteLine("2 - do-while");
Console.WriteLine("3 - foreach");
Console.Write("İşlem numarası: ");
index = Convert.ToInt32(Console.ReadLine());

// For Loop (Counter Controlled)
if (index == 0)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("I'm in a loop.");
        Console.WriteLine($"Counter value: {i}");
    }

    Console.WriteLine();
    Console.WriteLine("FOR LOOP FINISHED");
}

// While Loop (Condition Controlled - Pre Check)
if (index == 1)
{
    int n = 0;
    while (n < 5)
    {
        Console.WriteLine("Input a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your entered {n}: ");
    }

    Console.WriteLine();
    Console.WriteLine("WHILE LOOP FINISHED");
}

// Do-While Loop (Condition Controlled - Post Check)
if (index == 2)
{
    int number = 0;
    do
    {
        Console.WriteLine("Input a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your entered {number}: ");
    } while (number < 5);
}

// Foreach - Honourable Mention
if (index == 3)
{
    string[] names = new string[] { "Gökhan", "Hande", "Blablabla" };

    foreach (var name in names)
    {
        Console.WriteLine($"Name: {name}");
    }
}