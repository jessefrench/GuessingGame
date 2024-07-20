Random random = new Random();
int secretNumber = random.Next(1, 101);

Console.WriteLine("Psst! Hey you! Can you guess the secret number? I'll give you 4 chances ;)");

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
        int guessesLeft = 3 - i;

        if (playerGuess > secretNumber)
        {
            Console.WriteLine($"Ha! You guessed {playerGuess}. That's too high!");
        }
        else
        {
            Console.WriteLine($"Ha! You guessed {playerGuess}. That's too low!");
        }

        if (guessesLeft > 0)
        {
            Console.WriteLine($"You have {guessesLeft} guesses left.");
        }
        else
        {
            Console.WriteLine("You've used all your chances. Bye now!");
        }
    }
}