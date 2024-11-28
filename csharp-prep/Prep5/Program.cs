using System;

class Program
{
    static void Main(string[] args)
    {
        // Displaying WelcomeMessage
        DisplayWelcome();

        // prompting the user for their name
        string userName = PromptUserName();

        //prompting the user for their favourite number
        int favouriteNumber = PromptFavoriteNumber();

        //calculating th square of number
        int squareNumber = SquareNumber(favouriteNumber);

        //Displaying the final result
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter Your Name: ");
        return Console.ReadLine();
    }

    static int PromptFavoriteNumber()
    {
        Console.Write("Enter Your Favourite Number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber} ");
    }
}