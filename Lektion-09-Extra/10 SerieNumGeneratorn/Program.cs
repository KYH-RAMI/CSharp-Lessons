
class Produkt
{
    private static int _globalRäknare = 1000;
    public string Namn { get; set; }
    public int UniktID { get; private set; }

    public Produkt(string namn)
    {
        Namn = namn;
        UniktID = ++_globalRäknare; //Öka innan tilldelning
    }

}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 SerieNumGeneratorn");
        Console.Title = "10 SerieNumGeneratorn";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion


        List<Produkt> produkter = new List<Produkt>
        {
            new Produkt("Mjölk"),
            new Produkt("Kaffe"),
            new Produkt("Kanelbullar"),
            new Produkt("Äpple"),
            new Produkt("Kanelbullar"),
            new Produkt("Kaffe")
        };

        foreach (var produkt in produkter)
        {
            Console.WriteLine($"ID: {produkt.UniktID}, Produkt: {produkt.Namn}");
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}