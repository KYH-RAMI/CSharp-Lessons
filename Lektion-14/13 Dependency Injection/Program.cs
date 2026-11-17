
interface ILoggning
{
    void Logga(string meddelande);
}
class FilLoggare : ILoggning
{
    public void Logga(string meddelande)
        => Console.WriteLine($"[FILLOGG] {meddelande}");
}

class NavigationEngine
{
    private readonly ILoggning _loggning;

    public NavigationEngine(ILoggning loggning)
        => _loggning = loggning;

    public void Navigera(string destination)
    {
        Console.WriteLine($"Navigerar mot {destination}.");
        _loggning.Logga($"Navigation startad mot {destination}.");
    }
}

class Program
{
    static NavigationEngine SkapaNavigationEngine()
    {
        ILoggning loggare = new FilLoggare();

        return new NavigationEngine(loggare);
    }
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 - Dependency Injection");
        Console.Title = "13 - Dependency Injection";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        NavigationEngine navigation = SkapaNavigationEngine();

        navigation.Navigera("Stockholm");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}