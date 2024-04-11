public class WeeklyAbsence:Absence
{
    // private int absence;

    private DaylyAbsence _daylyAbsence;
    
    public WeeklyAbsence(string name, string description,int maxAbsence,DaylyAbsence daylyAbsence):base(name, description, maxAbsence)
    {
        _daylyAbsence = daylyAbsence;
    }

    public override int AccountForAbsence()
    {
        
        int absence = 0;
        int nuberOfDailyCalls = 0;
        while(nuberOfDailyCalls < 5)
        {
            int abs = _daylyAbsence.AccountForAbsence();
            absence += abs;

            nuberOfDailyCalls++;
            Console.WriteLine();
        }
        return absence; 
    }

    public override string GetDetailsStringRepresentation()
    {
        return string.Format("{0}: {1}-- {3}/{4}", GetName(), GetDescription(), AccountForAbsence(), GetMaxAbsence() );
    }


}