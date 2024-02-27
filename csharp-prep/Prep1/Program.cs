using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
          A simple program to demonstrate knowlegde and use of
          Variable, Input and Output. 
        */
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}