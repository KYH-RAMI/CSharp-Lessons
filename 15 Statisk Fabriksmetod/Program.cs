
class Anvandare
{
    public string Namn { get; private set; }

    public string Roll { get; private set; }

    // Privat konstruktor
    private Anvandare(string namn, string roll)
    {
        Namn = namn;
        Roll = roll;
    }

    // Statisk metod för att skapa en administratör
    public static Anvandare SkapaAdmin(string namn)
    {
        return new Anvandare(namn, "Admin");
    }

    // Statisk metod för att skapa en standardanvändare
    public static Anvandare SkapaStandardAnvandare(string namn)
    {
        return new Anvandare(namn, "Standard");
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Statisk Fabriksmetod");
        Console.Title = "15 Statisk Fabriksmetod";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Anvandare admin = Anvandare.SkapaAdmin("Rami");
        Anvandare standardAnvandare = Anvandare.SkapaStandardAnvandare("RoRo");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{admin.Namn} - ({admin.Roll}) Roll ");
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{standardAnvandare.Namn} - ({standardAnvandare.Roll}) Roll ");
        Console.ResetColor();
        Console.WriteLine();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}