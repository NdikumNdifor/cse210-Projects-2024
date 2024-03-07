public class Resume
{
    public string _firstName;
    public List<Job> _jobs = new List<Job>();
    
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_firstName}");
        Console.WriteLine("Job:");

        foreach(Job job in _jobs)
        {
            job.DisplayJob();
        }
        
    }

}