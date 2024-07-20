int secretNumber = 42;

Console.WriteLine("Psst! Hey you! Can you guess the secret number? I'll give you have 4 chances ;)");

for (int i = 0; i < 4; i++)
{
    Console.Write($"Attempt {i + 1}: ");
    int.TryParse(Console.ReadLine(), out int playerGuess);

    if (playerGuess == secretNumber)
    {
        Console.WriteLine($"Wow, you guessed {playerGuess}. That's correct... How did you do that? Are you cheating?");
        break;
    }
    else
    {
        Console.WriteLine($"Ha! You guessed {playerGuess}. That's not even close!");
    }
}