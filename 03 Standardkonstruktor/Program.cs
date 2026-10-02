
class Bil
{
    public string Marke { get; set; }
    public string Modell { get; set; }

    // Konstruktor som tar emot märke och modell som parametrar
    public Bil(string marke, string modell)
    {
        Marke = marke;
        Modell = modell;
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Standardkonstruktor");
        Console.Title = "03 Standardkonstruktor";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        
        // Skillnaden är att man initierar värden direkt i konstruktorn istället för att använda -
        // standardkonstruktorn och sedan tilldela värdena.
        // Detta kan vara användbart om man vill initiera värden direkt när man skapar en instans av klassen.

        Bil minBil = new Bil("Volvo", "V70");
        Bil minBil2 = new Bil("Mazda", "CX30");
        Console.WriteLine($"Märke: {minBil.Marke}");
        Console.WriteLine($"Modell: {minBil.Modell}");
        Console.WriteLine();
        Console.WriteLine($"Märke: {minBil2.Marke}");
        Console.WriteLine($"Modell: {minBil2.Modell}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
