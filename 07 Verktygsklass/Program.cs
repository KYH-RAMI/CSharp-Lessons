
class TextVerktyg
{
    public static string RensaText(string indata)
    {
        return indata.Trim().ToLower();
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 Statisk vs Instansmetod (Verktygsklass)");
        Console.Title = "07 Statisk vs Instansmetod (Verktygsklass)";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string text = "  Hej, världen!  ";
        Console.WriteLine($"Original: '{text}' ");
        Console.WriteLine($"Rensad: '{TextVerktyg.RensaText(text)}' ");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}