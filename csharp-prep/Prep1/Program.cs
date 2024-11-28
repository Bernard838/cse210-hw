using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Asking the user for second name
        Console.Write("What is your last name? " );
        string lastName = Console.ReadLine();

        //The formatted name display
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}