class SäkerFarkost
{
    public string Namn { get; }
    public string Registreringsnummer { get; }

    public SäkerFarkost(string namn, string registreringsnummer)
    {
        // Guard clause här
        if (string.IsNullOrWhiteSpace(namn))
        {
            throw new ArgumentException("Namnet får inte vara tomt.", nameof(namn));
        }

        // Sätt Namn
        // Sätt Registreringsnummer
        Namn = namn;
        Registreringsnummer = registreringsnummer;
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Dörrvakten");
        Console.Title = "01 Dörrvakten";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        var mazda = new SäkerFarkost("MAZDA", "ABC123");
        var volvo = new SäkerFarkost("Volvo", "DEF456");

        Console.WriteLine($"Farkost: {mazda.Namn}, Reg.nr: {mazda.Registreringsnummer}");
        Console.WriteLine($"Farkost: {volvo.Namn}, Reg.nr: {volvo.Registreringsnummer}");

        try
        {
            var felaktig = new SäkerFarkost("   ", "XYZ789");
        }
        catch (ArgumentException ex)
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