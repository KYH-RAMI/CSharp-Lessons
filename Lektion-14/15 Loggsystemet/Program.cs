
class TransaktionellLogg
{
    private readonly List<string> _loggar = [];
    private readonly List<string> _backup = [];

    public void LäggTillStabilLogg(string meddelande)
    {
        _loggar.Add(meddelande);
        UppdateraBackup();
    }

    public void VisaLogg()
    {
        foreach (string logg in _loggar)
        {
            Console.WriteLine(logg);
        }
    }

    public void SkrivTransaktionellt(string meddelande, bool simuleraFel)
    {
        UppdateraBackup();

        try
        {
            _loggar.Add(meddelande);

            if (simuleraFel)
            {
                throw new Exception("Simulerat fel under loggskrivningen.");
            }

            UppdateraBackup(); // transaktionen lyckades → nytt stabilt läge
        }
        catch
        {
            _loggar.Clear();
            _loggar.AddRange(_backup);

            throw;
        }
    }

    private void UppdateraBackup()
    {
        _backup.Clear();
        _backup.AddRange(_loggar);
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 - Det transaktionella Loggsystemet");
        Console.Title = "15 - Det transaktionella Loggsystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        TransaktionellLogg logg = new TransaktionellLogg();

        logg.LäggTillStabilLogg("Systemet startades.");
        logg.LäggTillStabilLogg("Motor kontrollerad.");

        Console.WriteLine("=== FÖRE TRANSAKTION ===");
        logg.VisaLogg();

        try
        {
            logg.SkrivTransaktionellt("Ny kritisk loggrad", true);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nFel: {ex.Message}");
            Console.WriteLine("Rollback genomförd.");
            Console.ResetColor();
        }

        Console.WriteLine("\n=== EFTER TRANSAKTION ===");
        logg.VisaLogg();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}