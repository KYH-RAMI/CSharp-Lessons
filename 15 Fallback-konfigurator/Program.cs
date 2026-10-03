class ElsystemKonfigurator
{
    private int _spänning;
    private bool _säkerhetsläge;

    public void LaddaKonfiguration()
    {
        try
        {
            Console.WriteLine("Laddar spänningsinställning...");
            _spänning = 230;

            Console.WriteLine("Laddar säkerhetsmodul...");

            // Simulerat fel halvvägs
            throw new Exception("Korrupt data i säkerhetsmodulen.");
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel vid inläsning av konfiguration.");
            Console.ResetColor();

            LaddaFabriksinställningar();
        }
    }

    private void LaddaFabriksinställningar()
    {
        _spänning = 230;
        _säkerhetsläge = true;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Fabriksinställningar har laddats.");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Robust fallback-konfigurator");
        Console.Title = "15 Robust fallback-konfigurator";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        ElsystemKonfigurator konfigurator = new ElsystemKonfigurator();

        konfigurator.LaddaKonfiguration();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }
}

