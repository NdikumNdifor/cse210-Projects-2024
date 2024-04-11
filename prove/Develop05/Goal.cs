public abstract class Goal
{
   private string _shortName;
   private string _description;
   private int _points;

   public Goal()
   {

   }

   public Goal(string shortName, string description, int points )
   {
    _shortName = shortName;
    _description = description;
    _points = points;

   }

    // Defining getters and setters for the class attributes
   public string GetShortName()
   {
        return _shortName;
   }

   public void SetShortName(string shortName)
   {
        _shortName = shortName;
   }

   public string GetDescription()
   {
        return _description;
   }

   public void SetDescription(string description)
   {
        _description = description;
   }

   public int GetPoints()
   {
        return _points;
   }

   public void SetPoints(int points)
   {
    _points = points;
   }



   public abstract void RecordEvent();
   

   public abstract bool IsComplete();
   

   public virtual string GetDetailsString()
   {
          if(IsComplete())
          {
               return $"[X]{_shortName}:{_description}";
          }
          else
          {
               return $"[]{_shortName}:{_description}";
          }
          
   }

   public abstract string GetStringRepresentation();
   
}