public class DailyAbsence:Absence
{
    private int _absence;
    private int _maxDailyPresence;

    public DailyAbsence(string name, string description, maxDailyAbsence):base(name, description)
    {
        _maxDailyAbsence = maxDailyAbsence;
    }

    public override int AccountForAbsence()
    {
        return _absences;
    }


}