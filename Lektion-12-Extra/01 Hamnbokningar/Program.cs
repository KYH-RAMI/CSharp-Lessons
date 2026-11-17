
class HamnBokning
{
    private static int _idRaknare = 1000;

    public int Id { get; private set; }
    public string BåtNamn { get; private set; }
    public string AnkomstDatum { get; private set; }

    public HamnBokning(string båtNamn, string ankomstDatum)
    {
        Id = _idRaknare;
        _idRaknare++;

        BåtNamn = båtNamn;
        AnkomstDatum = ankomstDatum;
    }

    public static int VisaHämtaNastaLedigId() => _idRaknare;
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Hamnbokningar");
        Console.Title = "01 Hamnbokningar";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        HamnBokning bokning1 = new HamnBokning("Båt1", "2026-10-01");
        HamnBokning bokning2 = new HamnBokning("Båt2", "2026-10-02");
        HamnBokning bokning3 = new HamnBokning("Båt3", "2026-10-03");

        Console.WriteLine($"Bokning 1 ID: {bokning1.Id}");
        Console.WriteLine($"Bokning 2 ID: {bokning2.Id}");
        Console.WriteLine($"Bokning 3 ID: {bokning3.Id}");

        Console.WriteLine($"Nästa lediga ID: {HamnBokning.VisaHämtaNastaLedigId()}");   

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}