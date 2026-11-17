
interface ILoggboksFilter
{
    bool Matchar(string loggsträng);
}
class LoggboksHanterare
{
    private readonly List<string> _loggsträngar = [];

    public void LäggTill(string loggsträng)
        => _loggsträngar.Add(loggsträng);

    public List<string> Filtrera(ILoggboksFilter filter)
        => _loggsträngar.Where(filter.Matchar).ToList();
}
class VäderFilter : ILoggboksFilter
{
    public bool Matchar(string loggsträng)
    => loggsträng.Contains("Storm", StringComparison.OrdinalIgnoreCase);
}

class ViktigtFilter : ILoggboksFilter
{
    public bool Matchar(string loggsträng)
        => loggsträng.Contains("Urgent", StringComparison.OrdinalIgnoreCase);
}
class FelFilter : ILoggboksFilter
{
    public bool Matchar(string loggsträng)
        => loggsträng.Contains("Fel", StringComparison.OrdinalIgnoreCase);
}
class SäkerhetsFilter : ILoggboksFilter
{
    public bool Matchar(string loggsträng)
        => loggsträng.Contains("Säkerhet", StringComparison.OrdinalIgnoreCase);
}
class DatumFilter : ILoggboksFilter
{
    public bool Matchar(string loggsträng)
        => loggsträng.Contains("Datum", StringComparison.OrdinalIgnoreCase);
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Loggboksfilter");
        Console.Title = "13 Loggboksfilter";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        LoggboksHanterare hanterare = new LoggboksHanterare();

        hanterare.LäggTill("Storm väntas under natten.");
        hanterare.LäggTill("Urgent: motorfel rapporterat.");
        hanterare.LäggTill("Normal drift.");
        hanterare.LäggTill("Urgent: Storm närmar sig hamnen.");

        ILoggboksFilter väderFilter = new VäderFilter();
        ILoggboksFilter viktigtFilter = new ViktigtFilter();

        List<string> väderLoggar = hanterare.Filtrera(väderFilter);
        List<string> viktigaLoggar = hanterare.Filtrera(viktigtFilter);

        Console.WriteLine("=== VÄDER ===");

        foreach (string logg in väderLoggar)
        {
            Console.WriteLine(logg);
        }

        Console.WriteLine("\n=== VIKTIGT ===");

        foreach (string logg in viktigaLoggar)
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

