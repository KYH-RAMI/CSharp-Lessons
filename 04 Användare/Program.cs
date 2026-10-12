namespace Användare;

public class Användare
{
    public string? Användarnamn
    {
        get; set;
    }
    public string? Epost
    {
        get; set;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Användare");
        Console.Title = "04 Användare";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Användare user = new Användare();
        user.Användarnamn = "RoRo";
        user.Epost = "RoRo@Koko.se";

        Console.WriteLine($"Användare: {user.Användarnamn} ({user.Epost})");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
