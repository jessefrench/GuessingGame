Random random = new Random();
int secretNumber = random.Next(1, 101);

Console.WriteLine("Psst! Hey you! Can you guess the secret number? I'll give you 4 chances ;)");

for (int i = 0; i < 4; i++)
{
    int.TryParse(Console.ReadLine(), out int playerGuess);

    if (playerGuess == secretNumber)
    {
        Console.WriteLine($"Wow, you guessed {playerGuess}. That's correct... How did you do that? Are you cheating?");
        break;
    }
    else
    {
        int guessesLeft = 3 - i;
        if (guessesLeft > 0)
        {
            Console.WriteLine($"Ha! You guessed {playerGuess}? That's not even close! You have {guessesLeft} guesses left.");
        }
        else
        {
            Console.WriteLine($"Ha! You guessed {playerGuess}? Sadly, that is incorrect and you've used up all your chances. Bye now!");
        }
    }
}