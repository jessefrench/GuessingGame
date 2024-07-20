Console.WriteLine("Can you guess the secret number?");
int.TryParse(Console.ReadLine(), out int guess);
Console.WriteLine($"You guessed: {guess}");