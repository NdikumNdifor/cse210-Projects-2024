public class Status
{
    private WeeklyAbsence _weeklyAbsence;
    // private MonthlyAbsence _monthlyAbsence;

    public Status(WeeklyAbsence weeklyAbsence, MonthlyAbsence monthlyAbsence)
    {
        _weeklyAbsence = weeklyAbsence;
        // _monthlyAbsence = monthlyAbsence;
    }
    public void DisplayStatus()
    {
        if(_weeklyAbsence.AccountForAbsence() < 5)
        {
            Console.WriteLine("You are good to go");
        }
        else if(_weeklyAbsence.AccountForAbsence() > 5 )
        {
            Console.WriteLine("You have a warning dismisal");
        }
        else if(_weeklyAbsence.AccountForAbsence() > 20) 
        {
            Console.WriteLine("You have been dismissed");
        }
    }
}