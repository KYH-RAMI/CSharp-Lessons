
class AnkarSlippException : Exception
{
    public AnkarSlippException(string message) : base(message)
    {
    }
}
class Program
{
    static void KontrolleraAnkare(double vindhastighet)
    {
        const double maxVindhastighet = 20.0;

        if (vindhastighet > maxVindhastighet)
        {
            throw new AnkarSlippException(
                $"Vinden är för stark! Vindhastighet: {vindhastighet} m/s. Max tillåten: {maxVindhastighet} m/s.");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Ankaret är säkert vid {vindhastighet} m/s.");
        Console.ResetColor();
    }
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 Eget Marint Undantag");
        Console.Title = "07 Eget Marint Undantag";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        try
        {
            double vindhastighet = 25.0; // Simulerad vindhastighet
            KontrolleraAnkare(vindhastighet);
        }
        catch (AnkarSlippException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }
}