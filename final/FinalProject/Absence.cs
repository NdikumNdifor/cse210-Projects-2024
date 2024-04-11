public abstract class Absence
{
    private string _name;
    private string _description;
    private int _maxAbsence;

    public string GetName()
   {
        return _name;
   }

   public void SetName(string shortName)
   {
        _name = shortName;
   }

   public string GetDescription()
   {
        return _description;
   }

   public void SetMaxAbsence(int maxAbsence)
   {
          _maxAbsence = maxAbsence;
   }

   public int GetMaxAbsence()
   {
          return _maxAbsence;
   }

   public void SetDescription(string description)
   {
        _description = description;
   }
    
    public Absence(string name, string description, int maxAbsence)
    {
        _name = name;
        _description = description;
        _maxAbsence = maxAbsence;
    }

    public virtual void DispalyDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"This is the {_name} report.");
        Console.WriteLine($"{_description}");

    }

//     public virtual int ComputeAbsences()
//     {
//         int numberOfAbsences = AccountForAbsence();
//         Console.WriteLine(numberOfAbsences);
//         return numberOfAbsences;
//     }

    public virtual string GetDetailsStringRepresentation()
    {
          return string.Format("{0}: {1}-- {3}/{4}", GetName(), GetDescription(), AccountForAbsence(), GetMaxAbsence() );
    }

    public abstract int AccountForAbsence();
    
}