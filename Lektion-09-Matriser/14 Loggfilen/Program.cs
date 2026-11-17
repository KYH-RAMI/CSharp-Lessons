
class Konfiguration
{
    static Konfiguration()
    {
        Console.WriteLine("Statisk konstruktor kördes");
    }
    public Konfiguration()
    {
        Console.WriteLine("Vanlig konstruktor kördes");
    }
    public static void SkrivLogg()
    {
        Console.WriteLine("Loggfilen skapad");
    }

}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Loggfilen");
        Console.Title = "14 Loggfilen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        
        Konfiguration.SkrivLogg();
        Konfiguration.SkrivLogg();

        Konfiguration k1 = new Konfiguration();
        Konfiguration k2 = new Konfiguration();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}