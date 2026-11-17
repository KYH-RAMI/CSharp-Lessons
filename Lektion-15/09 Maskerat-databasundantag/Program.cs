using System.Data.Common;

class DataHämtningsException : Exception
{
    public DataHämtningsException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

class SimuleratDbException : DbException
{
    public SimuleratDbException(string message)
        : base(message)
    {
    }
}

class Program
{
    static void HämtaPassagerarData()
    {
        try
        {
            throw new SimuleratDbException(
                "Fel i tabellen Passagerare på databas 192.168.1.50.");
        }
        catch (DbException ex)
        {
            throw new DataHämtningsException(
                "Passagerardata kunde inte hämtas.",
                ex);
        }
    }

    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 Maskerat databasundantag");
        Console.Title = "09 Maskerat databasundantag";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        try
        {
            HämtaPassagerarData();
        }
        catch (DataHämtningsException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();

            System.Diagnostics.Debug.WriteLine(
                $"ADMIN: {ex.InnerException?.Message}");
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }
}