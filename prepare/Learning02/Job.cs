public class Job
{
    public string _title;
    public string _startYear;
    public string _endYear;
    public string _company;
    public Job()
    {
        
    }

    public void DisplayJob(){
        Console.WriteLine($"{_title}({_company}) {_startYear}-{_endYear})");
    }
}