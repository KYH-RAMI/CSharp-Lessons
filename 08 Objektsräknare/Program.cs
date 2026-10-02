
class Medlem
{
    public static int AntalMedlemmar = 0;
    public Medlem()
    {
        AntalMedlemmar++;
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Objektsräknare");
        Console.Title = "08 Objektsräknare";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion


        Medlem medlem1 = new Medlem();
        Medlem medlem2 = new Medlem();
        Medlem medlem3 = new Medlem();
        Medlem medlem4 = new Medlem();
        Medlem medlem5 = new Medlem();
        Medlem medlem6 = new Medlem();
        Medlem medlem7 = new Medlem();
        Medlem medlem8 = new Medlem();

        Console.WriteLine($"Antal medlemmar: {Medlem.AntalMedlemmar}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}