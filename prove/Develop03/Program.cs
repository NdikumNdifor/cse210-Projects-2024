using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("proverbs", "3", "5", "6");
    //    string ref2 = scriptureReference.GetReference();

       Scripture scripture = new Scripture(scriptureReference, "This my imaginary proverb verbhere and so, do that is necessary");
       
       string userInput = "";

       while (userInput != "quit" && scripture.HasWordsLeft() == true)
       {
        Console.Clear();
        Console.WriteLine("👉 Press the enter key on your keybord to hide words");
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine();
        Console.ReadLine();
        scripture.RemoveWords();
       }
       Console.WriteLine(scripture.GetScripture()); 
    }
}