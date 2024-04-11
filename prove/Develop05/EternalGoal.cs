public class EternalGoal: Goal
{
    public EternalGoal()
    {
        
    }
    public EternalGoal(string shortName, string description, int points):base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return string.Format("{0}:{1}--{2}", GetShortName(), GetDescription(), GetPoints());
    }
}
