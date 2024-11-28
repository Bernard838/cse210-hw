using System;

class Program
{
    static void Main(string[] args)
    {
        //prompting the user  grade percentage
        Console.Write("Enter your grade percentage ");
        string input = Console.ReadLine();

        // changing the input into an interger
        int percentage = int.Parse(input);

        // finding the corresponding letter grade.
        string letter = "";
        if (percentage >= 90)

        {
            letter = "A";
        }
        else if (percentage >= 80)

        {
            letter = "B";
        }
        else if (percentage >= 70)

        {
           letter = "C"; 
        }
        else if (percentage >= 60)

        {
            letter = "D";
        }
        else

        {
            letter = "F";
        }

        // finding the grade sign(+ or -)
        string sign = "";
        if (letter != "F")  // no sign for F

        {
            int lastDigit = percentage % 10;
            if (lastDigit >=7)

            {
                sign = "+";
            }
            else if (lastDigit < 3)

            {
                sign ="-";
            }

            //solving the case where there is no A+
            if (letter == "A" && sign == "+")

            {
                sign = "";
            }
        }

        // showing the final grade and sign
        Console.WriteLine($"Your grade is {letter}{sign}");

        // checking if the user passed or failed
        if (percentage >= 70)

        {
            Console.WriteLine("Congratulations, you passed ");
        }
        else

        {
            Console.WriteLine("Next time better luck, Thanks! ");
        }
    }
}