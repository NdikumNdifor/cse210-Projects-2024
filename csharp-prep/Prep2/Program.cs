using System;

class Program
{
    static void Main(string[] args)
    {
        // A program that promts the user for their percentage grade and display their grade.
        // It also let them know if they pass or not(Practicing how to use conditional statements)
        
        Console.Write("Please enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

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
        Console.WriteLine($"Your overall grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Good job! you passed.");
        }
        else
        {
            Console.WriteLine("Sorry,you did not pass, We encourage you to come back next time.");
        }
    }
}