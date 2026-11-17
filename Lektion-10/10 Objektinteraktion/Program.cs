
class Bil
{
    public string Marke { get; set; }
    public string Modell { get; set; }
    public bool IsTrasig { get; set; }
    public Bil(string marke, string modell, bool isTrasig)
    {
        Marke = marke;
        Modell = modell;
        IsTrasig = isTrasig;
    }
}

class Mekaniker
{
    public void Reparera(Bil b)
    {
        if (b.IsTrasig)
        {
            b.IsTrasig = false;
            Console.WriteLine($"Mekaniker har reparerat bilen {b.Marke} {b.Modell}.");
        }
        else
        {
            Console.WriteLine($"Bilen {b.Marke} {b.Modell} är redan i gott skick.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Objektinteraktion");
        Console.Title = "10 Objektinteraktion";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Bil bil1 = new Bil("Volvo", "V70", true);
        Bil bil2 = new Bil("Mazda", "CX30", false);

        Mekaniker mekaniker = new Mekaniker();
        mekaniker.Reparera(bil1);
        mekaniker.Reparera(bil2);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}