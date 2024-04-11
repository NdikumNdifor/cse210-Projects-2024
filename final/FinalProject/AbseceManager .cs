public class AbsenceManager
{
    private List<Absence> _absences = new List<Absence>();
    private DaylyAbsence _dailyAbsence;
    private WeeklyAbsence _weeklyAbsence;
    private MonthlyAbsence _monthlyAbsence;

    public AbsenceManager(DaylyAbsence daylyAbsence, WeeklyAbsence weeklyAbsence, MonthlyAbsence monthlyAbsence)
    {
        _dailyAbsence = daylyAbsence;
        _weeklyAbsence = weeklyAbsence;
        _monthlyAbsence = monthlyAbsence;
    }

    private List<string> _menu = new List<string>()
    {
      "Menu Option:",
      "  1. Creat Absences",
      "  2. Show Absences",
    //   "  3. Save Goals",
    //   "  4. Load Goals",
      "  3. Open notification",
      "  4. Quit"
    };

    public AbsenceManager()
    {

    }
    public void Start()
    {
        int _optionNum = -1;
        while(_optionNum != 4)
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
                ListAbsenceName();
                CreateAbsence();
            }
            else if(_optionNum == 2)
            {
                ShowAbsences();
            }
            else if(_optionNum == 3)
            {
                Notification n = new Notification();
                n.CreateNotification();
                SaveAbsenceToCsV();
                LoadAbsencesFromCsv();
            }
        } 
    }

    public void ListAbsenceName()
    {
        Console.WriteLine("The types of Absences are:");
        Console.WriteLine("  1. Daily Absence");
        Console.WriteLine("  2. Weekly Absence");
        Console.WriteLine("  3. Monthly Absence");
    }

    public void DisplayAbsences()
    {
        foreach(Absence absence in _absences)
        {
            int listOfAbsences = absence.AccountForAbsence();
            Console.WriteLine($"{listOfAbsences}");
        }
    }

    public void CreateAbsence()
    {
       Console.Write("Which absence type you want to See? ");
        string userInput = Console.ReadLine();
        if(userInput == "1")
        {
            DaylyAbsence d = new DaylyAbsence("Daily Absence", "The dayly absence report gives a dayly summary of a student's hourly school attendance. The daily maximum number of hours is 8 and is given by responding 4 times to a row call with each respond corresponding to 2 hours of either present or absent.", 8);
            d.AccountForAbsence();
            // Console.WriteLine($"{d.AccountForAbsence()} absences out of 8");
            _absences.Add(d);
        }
        else if(userInput == "2")
        {
            DaylyAbsence daylyAbsence = new DaylyAbsence("Daily Absence", "Daily absence great descripion", 8);
            WeeklyAbsence w = new WeeklyAbsence("WeeklyAbsence","Weekly absence great description", 40, daylyAbsence );
            w.AccountForAbsence();
            _absences.Add(w);
            // Console.WriteLine($"{w.AccountForAbsence()} out of 40");
        }
        else if(userInput == "3")
        {
            DaylyAbsence daylyAbsence = new DaylyAbsence("Daily Absence", "Daily absence great descripion", 8);
            WeeklyAbsence w = new WeeklyAbsence("WeeklyAbsence","Here is the weekly, which tracks the number of absences of a student for 5 school days maxking a total number o f 40 hours per week.", 40, daylyAbsence);
            MonthlyAbsence m = new MonthlyAbsence("Monthly Absenece", "Here, a to tatal of 4 weeks is being tracke maxing a possible maximum absence of 160 hours per month, that is 40 per week times 4.", 160 , w);
            m.AccountForAbsence();
            _absences.Add(m);
            // Console.WriteLine($"{m.AccountForAbsence()} out of 160");
        } 

    }

    public void ShowAbsences()
    {
        
        foreach(Absence absence in _absences )
        {
            int listOfAbsences = absence.AccountForAbsence();
            Console.WriteLine($"{listOfAbsences}");
        }

    }

    public void SaveAbsenceToCsV()
    {
        string fileName = "notification.txt";
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach(Absence absence in _absences)
            {
                string csv = absence.GetDetailsStringRepresentation();
                outputfile.WriteLine(csv);
            }
        }

    }

    public void LoadAbsencesFromCsv()
    {
        
        
        string fileName = "notification.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }

    }
}

