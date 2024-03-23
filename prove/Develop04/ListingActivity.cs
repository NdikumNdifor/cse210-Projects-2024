public class ListingActivity: Activity
{
    private int _count = 0;
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {

    }

    public ListingActivity(string name , string description):base(name, description)
    {
        
    }

    public override void DisplayStartMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {GetName()}.");
        Console.WriteLine();
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        string _prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(_prompt);
    }

    public void GetListFromUser()
    {
        DisplayStartMessage();
        Console.Write("How long do you want to perform this activity: ");
        string userInput = Console.ReadLine();
        int _duration = int.Parse(userInput);
        GetRandomPrompt();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;

        List<string> inputList = new List<string>();
        while(currentTime < futureTime)
        {
            
            Console.Write(">> ");
            userInput = Console.ReadLine();
            inputList.Add(userInput);

            _count = inputList.Count();
            
            /*  Update the current time */
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You have listed {_count} items");

    }

    public void Run()
    {
        GetListFromUser();
        DisplayEndMessage();
    }
    
}