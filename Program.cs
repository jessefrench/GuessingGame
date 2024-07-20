Console.WriteLine(@"Welcome to The Guessing Game!
Please choose a difficulty level:
1. Easy
2. Medium
3. Hard
4. Cheater");

string difficulty = Console.ReadLine();
int attempts = 0;
bool infiniteAttempts = false;
Random random = new Random();
int secretNumber = random.Next(1, 101);

switch (difficulty)
{
    case "1":
        attempts = 8;
        break;
    case "2":
        attempts = 6;
        break;
    case "3":
        attempts = 4;
        break;
    case "4":
        infiniteAttempts = true;
        break;
    default:
        Console.WriteLine("Invalid difficulty level. Defaulting to Hard.");
        attempts = 4;
        break;
}

if (infiniteAttempts)
{
    Console.WriteLine("Can you guess the secret number? You can keep guessing until you get it right.");

    while (true)
    {
        int.TryParse(Console.ReadLine(), out int playerGuess);

        if (playerGuess == secretNumber)
        {
            Console.WriteLine($"Wow, you guessed {playerGuess}. That's correct... How did you do that? Are you cheating?");
            break;
        }
        else
        {
            if (playerGuess > secretNumber)
            {
                Console.WriteLine($"Ha! You guessed {playerGuess}. That's too high!");
            }
            else
            {
                Console.WriteLine($"Ha! You guessed {playerGuess}. That's too low!");
            }
        }
    }
}
else
{
    Console.WriteLine($"Can you guess the secret number? You get {attempts} attempts.");

    for (int i = 0; i < attempts; i++)
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
            int guessesLeft = attempts - i - 1;

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
}