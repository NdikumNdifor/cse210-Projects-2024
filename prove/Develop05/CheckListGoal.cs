public class ChecklistGoal: Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus):base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
          Console.WriteLine($"Congratulations, you have earned {_bonus} points ");   
    }
   

   public override bool IsComplete()
   {
     return true;
   }

   public override string GetDetailsString()
   {
     
     if (_amountCompleted >= _target)
     {
          return $"[X]{GetShortName()}: {GetDescription()} -- {GetPoints()} -- string({_target}/{_target})"; 
     }
     else
     {
          return $"[]{GetShortName()}: {GetDescription()} -- {GetPoints()} -- {_amountCompleted}/{_target}";  
     }

   }

   public override string GetStringRepresentation()
   {
        return string.Format("{0}: {1} - {2} - {3} - {4}", GetShortName(), GetDescription(), GetPoints(), _bonus, _target, _amountCompleted);
   }
}