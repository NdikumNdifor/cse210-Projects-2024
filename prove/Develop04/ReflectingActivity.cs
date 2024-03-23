public class ReflectingActivity: Activity
{
    private string[] _prompts = 

    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = 

    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name , string description):base(name, description)
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

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        string _prompt = _prompts[rand.Next(_prompts.Length)];
        return _prompt;  
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        string _question = _questions[rand.Next(_prompts.Length)];
        return _question;  
    }

    public void DisplayPrompt()
    {
       string _prompt = GetRandomPrompt();
       Console.WriteLine(_prompt);
    }

    public void DisplayQuestions()
    {
        string _question = GetRandomQuestion();
        Console.WriteLine(_question);
    }


    public void Run()
    {
        Console.WriteLine();
        DisplayStartMessage();
        Console.Write("How long do you want to perform this activity: ");
        string userInput = Console.ReadLine();
        int _duration = int.Parse(userInput);
        DisplayPrompt();
        ShowSpinner(12);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime)
        {
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(7);
            
            /*  Update the current time */
            currentTime = DateTime.Now;
        }

        DisplayEndMessage();

    }
    
}


    


