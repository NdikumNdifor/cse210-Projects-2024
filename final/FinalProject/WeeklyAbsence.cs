public class WeeklyAbsence:Absence
{
    public WeeklyAbsence(string name, string description):base(name, description)
    {

    }

    public override int AccountForAbsence()
    {
        return 2;
    }

    public override string GetDetailsStringRepresentation()
    {
        return string.Format("");
    }


}