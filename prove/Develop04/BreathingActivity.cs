public class BreathingActivity:Activity
{
    public BreathingActivity()
    {

    }
    public BreathingActivity(string name, string description):base(name, description)
    {

    }

    // public override void DisplayStartMessage()
    // {
    //     Console.WriteLine();
    //     Console.WriteLine($"Welcome to the {GetName()}.");
    //     Console.WriteLine();
    //     Console.WriteLine($"{GetDescription()}");
    //     Console.WriteLine();
    // }

    public void Run()
    {
        DisplayStartMessage();
        Console.Write("How long do you want to perform this activity: ");
        string userInput = Console.ReadLine();
        int _duration = int.Parse(userInput);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime)
        {
            Console.Write("Breath In............");
            ShowCountDown(1000);
            
            Console.Write("Breath Out..........");
            ShowCountDown(1000);
            Console.WriteLine();
            
            /*  Update the current time */
            currentTime = DateTime.Now;
        }

        DisplayEndMessage();
        
    }
}