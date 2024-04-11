using System;
using System.Runtime.Loader;

class Program
{
    static void Main(string[] args)
    {
        AbsenceManager manager = new AbsenceManager();
        manager.Start();

        // DaylyAbsence daylyAbsence = new DaylyAbsence("a","b",8);

        // static void DisplayAbsences(Absence a)
        // {
        //     int absence = a.AccountForAbsence();
        //     Console.WriteLine(absence);
        //     int w = a.AccountForAbsence();
        // }
        // DisplayAbsences(daylyAbsence);

    }
}