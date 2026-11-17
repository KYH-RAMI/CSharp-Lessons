
class NätverksKlient
{
    public string HämtaData()
    {
        throw new TimeoutException("API-anropet tog för lång tid.");
    }
}
class VäderTjänst
{
    private readonly NätverksKlient _klient;

    public VäderTjänst(NätverksKlient klient)
        => _klient = klient;

    public string HämtaVäder()
        => _klient.HämtaData();
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 - Det säkra API-anropet");
        Console.Title = "12 - Det säkra API-anropet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        NätverksKlient klient = new NätverksKlient();
        VäderTjänst väderTjänst = new VäderTjänst(klient);

        try
        {
            string väder = väderTjänst.HämtaVäder();
            Console.WriteLine(väder);
        }
        catch (TimeoutException ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"VARNING: {ex.Message}");
            Console.ResetColor();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}