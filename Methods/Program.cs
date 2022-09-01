// See https://aka.ms/new-console-template for more information

// Prototype - Defines the function (type, name and parameters)
// Definition - Has the code. It contains the code block
// Function Call - Makes the function
// DRY - Don't Repeat Yourself

// Void Functions - Completes a task and moves along
void PrintName()
{
    Console.WriteLine("c0deMach1ne");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

// Value Returning Functions - Completes a task, returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int result = num1;

    if (result < num2)
    {
        result = num2;
    }

    if (result < num3)
    {
        result = num3;
    }

    return result;
}

PrintName();
Console.WriteLine("End of Void Function");

Console.Write("Enter number #1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number #2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
Console.WriteLine("End of Void Function");

Console.Write("Enter number #3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");