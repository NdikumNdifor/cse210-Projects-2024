using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    /* Setting the Getters and Setters for the various attributes*/
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public virtual void DisplayStartMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }
    
    public virtual void DisplayEndMessage()
    {
        Console.WriteLine($"You succesfully completed this activity, you can be proud of yourself. Congratulations!");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        
        while(DateTime.Now < endTime)
        {
            // Console.Write(".");
            // Thread.Sleep(1000);
            string s = animationString[i];

            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
 
        }

    }

    public void ShowCountDown(int seconds)
    {
        for(int i = 5; i > 0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done");

        // for(int i = 5; i > 0; i-- )
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        //     // Console.Write("\b \b");
        // }
        // Console.WriteLine("Done");

        
        // foreach(string s in animationString)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        // Console.WriteLine("Done");

    }
    
}