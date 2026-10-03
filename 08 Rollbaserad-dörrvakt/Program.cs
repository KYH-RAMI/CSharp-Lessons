
class LänspumpsSystem
{
    public void StartaLänspump(string användarRoll)
    {
        if(användarRoll != "Kapten" && användarRoll != "Maskinist")
        {
            throw new UnauthorizedAccessException("Endast Kapten eller Maskinist kan starta länspumpen.");
        }
        // Starta länspumpen

        Console.WriteLine("Länspumpen har startats.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Rollbaserad dörrvakt");
        Console.Title = "08 Rollbaserad dörrvakt";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        LänspumpsSystem system = new LänspumpsSystem();

        system.StartaLänspump("Kapten");

        try
        {
            system.StartaLänspump("Gäst");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Åtkomst nekad: {ex.Message}");
            Console.ResetColor();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}