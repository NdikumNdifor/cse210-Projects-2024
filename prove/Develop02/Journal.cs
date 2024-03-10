using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry()
    {
        PromtGenerator randomPrommt = new PromtGenerator();
        string prompt = randomPrommt.GetRandomPrompt();

        Console.Write(">> ");
        string response = Console.ReadLine();

        var todayDate = DateTime.Today;
        string date = todayDate.ToString();

        Entry newEntry = new Entry(DateTime.Now.Date.ToString("MMM dd, yyyy"), prompt, response);

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Please enter your file name without any extension: ");
        string entrerd = Console.ReadLine();
        
        string extension = ".csv";
        string fileName = string.Concat(entrerd, extension);
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
                string csv = entry.GetEntryAsCSV();
                outputfile.WriteLine(csv);
            }
        }
    }

    public void LoadFromFile()
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