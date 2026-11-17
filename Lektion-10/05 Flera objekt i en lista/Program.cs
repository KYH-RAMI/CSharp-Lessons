
class Produkt
{
    public string Namn { get; set; }
    public decimal Pris { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Flera objekt i en lista");
        Console.Title = "05 Flera objekt i en lista";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        List<Produkt> produkter = new List<Produkt>
        {
            new Produkt { Namn = "Produkt 1", Pris = 10m },
            new Produkt { Namn = "Produkt 2", Pris = 20m },
            new Produkt { Namn = "Produkt 3", Pris = 30m }
        };

        foreach (var produkt in produkter)
        {
            Console.WriteLine($"Produkt: {produkt.Namn} ");
            Console.WriteLine($"Pris: {produkt.Pris:C}  ");
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}