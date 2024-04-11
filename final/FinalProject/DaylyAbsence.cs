public class DaylyAbsence:Absence
{
    // private int _absence;
    // private int _maxAbsence;

    public DaylyAbsence(string name, string description, int maxAbsence):base(name, description, maxAbsence)
    {
        // _maxAbsence = maxDailyAbsence;
    }

    public override int AccountForAbsence()
    {
        DispalyDetails();
        Console.WriteLine();
        int _absence = 0;

        int numberOfCalls = 0;
        while(numberOfCalls < 4)
        {
            Console.Write("Respond to row call to indicate presence or absence(P/A): ");
            string userInput = Console.ReadLine();
            // numberOfCalls = int.Parse(useInput);
            if(userInput.ToUpper() == "A")
            {
                _absence += 2;
            }
            else if(userInput.ToUpper() == "P")
            {
                _absence += 0;
            }
            numberOfCalls++;
        }
        return  _absence;
    }

    // public override int ComputeAbsences()
    // {
    //     int numberOfAbsences = AccountForAbsence();
    //     Console.WriteLine(numberOfAbsences);
    //     return numberOfAbsences;
    // }

    public override string GetDetailsStringRepresentation()
    {
        return string.Format("{0}: {1}-- {3}/{4}", GetName(), GetDescription(), AccountForAbsence(), GetMaxAbsence() );
    }


}