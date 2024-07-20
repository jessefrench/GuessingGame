int secretNumber = 42;

Console.WriteLine("Can you guess the secret number? You have 4 attempts.");

for (int i = 0; i < 4; i++)
{
    Console.Write($"Attempt {i + 1}: ");
    int.TryParse(Console.ReadLine(), out int playerGuess);

    if (playerGuess == secretNumber)
    {
        Console.WriteLine("Wow, you actually got it right. How did you do that? Are you cheating?");
        break;
    }
    else
    {
        Console.WriteLine("Ha! Not even close.");
    }
}