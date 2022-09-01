string secretWord = "c0deMach1ne";
string guessWord = string.Empty;
int guessCount = 0;
int guessLimit = 3;
bool outOfLimit = false;

while (guessWord != secretWord && !outOfLimit)
{
    if (guessCount < guessLimit)
    {
        Console.Write("Enter guess: ");
        guessWord = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfLimit = true;
    }
}

if (outOfLimit)
{
    Console.WriteLine("You lose!");
}
else
{
    Console.WriteLine("You win!");
}

Console.ReadLine();