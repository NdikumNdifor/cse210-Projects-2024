public abstract class Absence
{
    private string _name;
    private string _description;
    
    public Absence(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void DispalyDetails()
    {

    }

    public abstract string GetDetailsStringRepresentation();

    public abstract int AccountForAbsence();


    
}