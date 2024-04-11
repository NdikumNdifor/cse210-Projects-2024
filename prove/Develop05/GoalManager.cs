using System.Drawing;

public class GoalManager
{
   private List<Goal> _goals = new List<Goal>();
   private int _score = 0;

   private List<string> _menu = new List<string>()
   {
      "Menu Option:",
      "  1. Creat New Goal",
      "  2. List Goals",
      "  3. Save Goals",
      "  4. Load Goals",
      "  5. Record Event",
      "  6. Quit"
   };

   public GoalManager()
   {

   }

   
   public void Start()
   {
      int _optionNum = -1;
      while(_optionNum != 6)
      {
         foreach(string menu in _menu)
         {
            Console.WriteLine(menu);
         }

         Console.Write("Select a choice from the menu: ");
         string userInput = Console.ReadLine();
         _optionNum = int.Parse(userInput);

         if(_optionNum == 1)
         {
            ListGoalNames();
            CreateGoals();
         }
         else if(_optionNum == 2)
         {
            ListGoalDetails();
         }

         else if(_optionNum == 3)
         {
            SaveGoals();
         }
         else if(_optionNum == 4)
         {
            LoadGoals();
         }
         else if(_optionNum == 5)
         {
            RecordEvent();
         }
      }
   }
   public void DisplayPlayerInfo(int points)
   {
      _score += points;
      Console.WriteLine($"You have {_score} points"); 
   }

   public void ListGoalNames()
   {
     Console.WriteLine("The types of goals are:");
     Console.WriteLine("  1. Simple Goal");
     Console.WriteLine("  2. Eternal Goal");
     Console.WriteLine("  3. CheckList Goal"); 
   }

   public void ListGoalDetails()
   {
      foreach(Goal goal in _goals)
      {
         string listOfGoals = goal.GetDetailsString();
         Console.WriteLine($"{listOfGoals}");
      }
   }

   public void CreateGoals()
   {
      Console.Write("Which type of goal do you want to creat? ");
      string _goalNumber = Console.ReadLine();
      if(_goalNumber == "1")
      {
         Console.Write("What is the name of your goal: ");
         string shortName = Console.ReadLine();

         Console.Write("What is a short description of your Goal? ");
         string description = Console.ReadLine();

         Console.Write("What is the amount of points associated with this goal? ");
         string inputPoints = Console.ReadLine();
         int points = int.Parse(inputPoints);
         SimpleGoal simple = new SimpleGoal(shortName, description, points);
         _goals.Add(simple);
      }
      else if(_goalNumber == "2")
      {
         Console.Write("What is the name of your goal: ");
         string shortName = Console.ReadLine();

         Console.Write("What is a short description of your Goal? ");
         string description = Console.ReadLine();

         Console.Write("What is the amount of points associated with this goal? ");
         string inputPoints = Console.ReadLine();
         int points = int.Parse(inputPoints);
         EternalGoal eternal = new EternalGoal(shortName, description, points);

         _goals.Add(eternal);

      }
      else if(_goalNumber == "3")
      {
         Console.Write("What is the name of your goal: ");
         string shortName = Console.ReadLine();

         Console.Write("What is a short description of your Goal? ");
         string description = Console.ReadLine();

         Console.Write("What is the amount of points associated with this goal? ");
         string inputPoints = Console.ReadLine();
         int points = int.Parse(inputPoints);

         Console.Write("How many times does this goal need to be accomplished for a bonus? ");
         string targetNum = Console.ReadLine();
         int target = int.Parse(targetNum);

         Console.Write("How many times does this goal need to be accomplished for a bonus? ");
         string bonusNum = Console.ReadLine();
         int bonus = int.Parse(bonusNum);
         ChecklistGoal checklist = new ChecklistGoal(shortName, description, points, target, bonus);

         _goals.Add(checklist);

      }
   }

   public void RecordEvent()
   {
      Console.Write("Which goal did you accomplish? ");
      string userInput = Console.ReadLine();
      SimpleGoal s = new SimpleGoal();
      s.SetIsComplete(true);
      if(userInput == "1" )
      {
         s.SetIsComplete(true);
         s.RecordEvent();
         s.GetDetailsString();
      }

      else if (userInput == "2")
      {
         EternalGoal e = new EternalGoal();
         
      }
   }

   public void SaveGoals()
   {
      Console.WriteLine("Please enter your file name without any extension: ");
        string entrerd = Console.ReadLine();
        
        string extension = ".csv";
        string fileName = string.Concat(entrerd, extension);
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goals)
            {
                string csv = goal.GetStringRepresentation();
                outputfile.WriteLine(csv);
            }
        }
   }

   public void LoadGoals()
   {
      Console.WriteLine("Please enter your file name without any extension: ");
        
        string entrerd = Console.ReadLine();
        string extension = ".csv";
        string fileName = string.Concat(entrerd, extension);
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
   }  
}