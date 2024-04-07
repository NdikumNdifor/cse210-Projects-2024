public class MonthlyAbsence:Absence
{
    private WeeklyAbsence _weeklyAbsence;

    public MonthlyAbsence(string name, string description, WeeklyAbsence weeklyAbsence):base(name, description)
    {
        _weeklyAbsence = weeklyAbsence;
    }


    public override int AccountForAbsence()
    {
        return _weeklyAbsence.AccountForAbsence();        
    }

    public override string GetDetailsStringRepresentation()
    {
        throw new NotImplementedException();
    }
}