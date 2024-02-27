using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a number guessing game, Guess a number between 1 and 100");
        // Generates a random number between 1-100
        Random randomGenerator = new Random();
        int theNumber = randomGenerator.Next(1, 100);

        // Initializes the guess number to -1
        int guess = -1;
        int guessCount = 0;

        // Keeps on looping while the guess is not equale to the set value(the magic number)
        // and guide the user on his next choice
        while (guess != theNumber)
            {
                Console.Write("What is your guess number? ");
                string myMagicNumber = Console.ReadLine();
                guess = int.Parse(myMagicNumber);
                if (guess == theNumber)
                {
                    Console.WriteLine("You have guessed it correctly");
                }
                else if (guess > theNumber)
                {
                    Console.WriteLine("You guessed High, guess lower"); 
                }
                else if (guess < theNumber)
                {
                    Console.WriteLine("You guessed Low, guess higher");
                }
                guessCount += 1;
            }
            Console.WriteLine($"You succeeded after {guessCount} guesses.");    
    }
}