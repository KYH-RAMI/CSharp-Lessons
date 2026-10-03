
class LoggboksSkrivare
{
    private readonly List<string> _loggar = [];

    public void LäggTill(string meddelande)
        => _loggar.Add($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {meddelande}");

    public IReadOnlyList<string> HämtaLoggar()
        => _loggar.AsReadOnly();
}



class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Enkel Loggbok");
        Console.Title = "03 Enkel Loggbok";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        LoggboksSkrivare loggbok = new LoggboksSkrivare();

        loggbok.LäggTill("Systemet startades.");
        loggbok.LäggTill("Fartyget anlände till hamnen.");
        loggbok.LäggTill("Lossning påbörjad.");

        foreach (string logg in loggbok.HämtaLoggar())
        {
            Console.WriteLine(logg);
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}