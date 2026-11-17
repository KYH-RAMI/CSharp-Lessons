class HastighetsRegulator
{
    private int _aktuellKnop;

    public int AktuellKnop
    {
        get => _aktuellKnop;

        set
        {
            if (value < 0 || value > 30)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Hastigheten måste vara mellan 0 och 30 knop.");
            }

            _aktuellKnop = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Fartbegränsaren");
        Console.Title = "02 Fartbegränsaren";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        HastighetsRegulator regulator = new HastighetsRegulator();

        regulator.AktuellKnop = 15;
        Console.WriteLine($"Aktuell hastighet: {regulator.AktuellKnop} knop");

        try
        {
            regulator.AktuellKnop = 35;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }

        Console.WriteLine(
            $"Aktuell hastighet efter felaktigt försök: {regulator.AktuellKnop} knop");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }
}