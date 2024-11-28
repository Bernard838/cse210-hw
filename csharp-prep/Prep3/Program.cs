using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            // Creating a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.WriteLine("The Guess My Number game is now open!");
            Console.WriteLine("A number in the range of 1 and 100 comes to mind. (Can you guess it?)");

            int guess = 0;
            int attempts = 0;

            // Loop until the user guesses the correct number
            do
            {
                // Asking the user for a guess
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Attempt to parse the input and handle invalid cases
                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    // Providing feedback
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("Wow, you guessed it!");
                        Console.WriteLine($"It took you {attempts} guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            } while (guess != magicNumber);

            // Asking the user if they want to play again
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thank you for playing! Goodbye.");
    }
}
