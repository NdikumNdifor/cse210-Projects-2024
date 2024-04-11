public class MonthlyAbsence:Absence
{
    private int absence;
    private WeeklyAbsence _weeklyAbsence;

    public MonthlyAbsence(string name, string description,int maxAbsence, WeeklyAbsence weeklyAbsence):base(name, description, maxAbsence)
    {
        _weeklyAbsence = weeklyAbsence;
    }


    public override int AccountForAbsence()
    {
        absence = 0;
        int numberOfWeeklyCalls = 0;
        while(numberOfWeeklyCalls < 4)
        {
            // _weeklyAbsence.AccountForAbsence();
            int abs = _weeklyAbsence.AccountForAbsence();
            absence += abs;

            numberOfWeeklyCalls++;
        }
        return absence;        
    }
    

    public override string GetDetailsStringRepresentation()
    {
        throw new NotImplementedException();
    }
}