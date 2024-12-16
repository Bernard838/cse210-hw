using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Assignment class
        Assignment assignment = new Assignment("Samuel Mckline", "Multiplication");
        Console.WriteLine(assignment.GetSummary()); // Output: Samuel Bennett - Multiplication

        // Test MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Yoon", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());       // Output: Roberto Rodriguez - Fractions
        Console.WriteLine(mathAssignment.GetHomeworkList());  // Output: Section 7.3 Problems 8-19

        // Test WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Benedicta Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());        // Output: Mary Waters - European History
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Output: The Causes of World War II by Mary Waters
    }
}
