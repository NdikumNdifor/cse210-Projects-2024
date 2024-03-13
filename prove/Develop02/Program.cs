using System;

/* Implimenting the program class */
class Program
{
    static void Main(string[] args)
    {
        Journal j1 = new Journal();
       
        List<string> menu = new List<string>()
        {
            "Please select one of the following choices",
            "1. Write",
            "2. Display",
            "3. Save",
            "4. Load",
            "5. Quit",
            "Chose what you want to do"  
        };

        int task = -1;
        while(task != 5)
        {
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            string userInput = Console.ReadLine();
            task = int.Parse(userInput);
            
            if (task == 1)
            {
                j1.AddEntry();
            }

            else if(task == 2)
            {  
               j1.DisplayAll();
            }

            else if (task == 3)
            {
                j1.SaveToFile();
            }

            else if (task == 4)
            {
                j1.LoadFromFile();
            }

            else if (task == 5)
            {
                break;
            }

            else
            {
                Console.WriteLine("You are not entering a valid option");
            }
            
        }
    }
}