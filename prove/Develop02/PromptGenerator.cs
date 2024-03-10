class PromtGenerator
{
   // List<string> _prompts = new List<string>();

   public string[] _prompts = 

    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public PromtGenerator()
    {
        
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        string _prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(_prompt);
        return _prompt;  
    }
    
}