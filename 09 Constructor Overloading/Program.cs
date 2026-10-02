
class Kurs
{
    public string Kursnamn { get; set; }
    public string Kurskod { get; set; }
    // Konstruktor som tar emot både kursnamn och kurskod
    public Kurs(string kursnamn, string kurskod)
    {
        Kursnamn = kursnamn;
        Kurskod = kurskod;
    }
    // Konstruktor som tar emot endast kursnamn och sätter kurskod till "TBD"
    public Kurs(string kursnamn)
    {
        Kursnamn = kursnamn;
        Kurskod = "TBD";
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 Constructor Overloading");
        Console.Title = "09 Constructor Overloading";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Kurs kurs1 = new Kurs("C# Programmering", "C#-01");
        Kurs kurs2 = new Kurs("Webbprogrammering");

        Console.WriteLine($"Kurs 1: {kurs1.Kursnamn} ({kurs1.Kurskod}) ");
        Console.WriteLine($"Kurs 2: {kurs2.Kursnamn} ({kurs2.Kurskod}) ");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}