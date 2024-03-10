public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _response = response;
        _prompt = prompt;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt} {_response}");
    }

    public string GetEntryAsCSV()
    {
        return string.Format("{0}-{1}-{2}", _date, _prompt, _response);
    }    
}