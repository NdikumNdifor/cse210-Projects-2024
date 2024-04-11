public class SimpleGoal: Goal
{
    private bool _isComplete;

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete; 
    }

    public SimpleGoal()
    {

    }
    public SimpleGoal(string shortName, string description, int points):base(shortName, description, points)
    {
       
    }

    public override void RecordEvent()
    {
        // _isComplete = true;
        // IsComplete();
        // GetDetailsString(); 
        // Console.WriteLine($"Congratulations, you have earned {GetPoints()}");
        // GoalManager manager = new GoalManager();
        // manager.DisplayPlayerInfo(GetPoints());
        IsComplete();

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return string.Format("{0}:{1}-{2}-{3}", GetShortName(), GetDescription(), GetPoints(), _isComplete);
    }
}