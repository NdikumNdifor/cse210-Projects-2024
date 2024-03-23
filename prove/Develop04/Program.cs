using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numOfActivities = new List<int>();
        List<string>  menu = new List<string>()
        {
            "Please choose the activity number you want to perform",
            "1. BreathingActivity",
            "2. ReflectingActivit",
            "3. ListingActivity",
            "4. Quit"
        };

        int taskNumber = 0;
        while(taskNumber != 4)
        {
            foreach(string task in menu)
            {
                Console.WriteLine(task);
            }

            Console.Write("Which activity do you wish to perform: ");
            string userInput = Console.ReadLine();
            taskNumber = int.Parse(userInput);
            numOfActivities.Add(taskNumber);

            if(taskNumber == 1)
            {
                BreathingActivity b = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                b.Run();
            }

            else if(taskNumber == 2)
            {
                ReflectingActivity r = new ReflectingActivity("Reflecting Activity", "This activity will help you reflectb on time in your life when you have shown strength resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.");
                r.Run();
            }

            else if(taskNumber == 3)
            {
                ListingActivity l = new ListingActivity("Listing Activity", "This activity will help you re");
                l.Run();
            }


        }


        int activity = numOfActivities.Count() - 1;
        if(activity == 0)
        {
            Console.WriteLine($"You disn't perform any activity");
        }

        else if(activity == 1)
        {
            Console.WriteLine($"You have performed 1 activity");
        }

        else if(activity > 1)
        {
            Console.WriteLine($"You have performed {activity} activities");
        }
        
        
    }
}