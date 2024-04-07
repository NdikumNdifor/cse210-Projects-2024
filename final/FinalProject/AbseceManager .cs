public class AbsenceManager
{
    private List<Absence> _absences = new List<Absence>();

    private List<string> _menu = new List<string>()
    {
      "Menu Option:",
      "  1. Creat Absences",
      "  2. List Absences",
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

    }

    public void CreatAbsences()
    {

    }

    public void SaveAbsenceToCsV()
    {

    }

    public void LoadAbsencesFromCsv()
    {

    }
}