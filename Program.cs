int secretNumber = 42;

Console.WriteLine("Can you guess the secret number?");
int.TryParse(Console.ReadLine(), out int playerGuess);

if (playerGuess == secretNumber)
{
    Console.WriteLine("Wow, you actually got it right. How did you do that? Are you cheating?");
}
else
{ 
    Console.WriteLine("Ha! Not even close. Bye now!");
}