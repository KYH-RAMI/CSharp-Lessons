
class Anvandare
{
    public string Anvandarnamn { get; set; }
    public string Epost { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Egenskaper");
        Console.Title = "02 Egenskaper";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Anvandare anvandare = new Anvandare();
        anvandare.Anvandarnamn = "Rami";
        anvandare.Epost = "rami@rami.com";
        Console.WriteLine($"Användarnamn: {anvandare.Anvandarnamn} ");
        Console.WriteLine($"Epost: {anvandare.Epost} ");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}