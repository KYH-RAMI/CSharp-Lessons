
class LagerKort
{
    private Dictionary<string, int> lager = new Dictionary<string, int>();
    public int this[string artikelNamn]
    {
        get
        {
            if (lager.ContainsKey(artikelNamn))
            {
                return lager[artikelNamn];
            }
            else
            {
                return 0;
            }
        }
        set
        {
            lager[artikelNamn] = value;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 Reservdelslager");
        Console.Title = "09 Reservdelslager";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        LagerKort lagerKort = new LagerKort();

        lagerKort["Länspump"] = 3;
        lagerKort["Säkringar 10A"] = 10;

        lagerKort["Säkringar 10A"] = lagerKort["Säkringar 10A"] + 5;

        Console.WriteLine($"Länspump: {lagerKort["Länspump"]}");
        Console.WriteLine($"Säkringar 10A: {lagerKort["Säkringar 10A"]}");


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}