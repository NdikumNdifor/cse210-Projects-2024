using System;

class Program
{
    static void Main(string[] args)
    {
        // A call to writen functions at the main.
        DisplayWelcome();
        string EnteredName = PromtUserName();
        int EnteredNumber = PromtUserNumber();
        int computeSquare = SquareNumber(EnteredNumber);
        DisplayResult(EnteredName, computeSquare);
        

        // A function with that displays a welcome message and takes no parameter.
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the programm");
        }

        // Ask for the user's name and returns a string.
        static string PromtUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Ask for the user's favorite number and returns an interger.
        static int PromtUserNumber()
        {
            Console.Write("Eenter your favorite number: ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        // Takes an interger as parameter,computes the squre of that interger and returns it.
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // Takes a string and interger as parameters and display a result.
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Your name is {name} and the square of your number is {square} ");
        }
        
    }
}