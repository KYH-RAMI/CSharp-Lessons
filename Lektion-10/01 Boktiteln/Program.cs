  
class Bok
{
    public string Titel;
    public string Forfattare;

}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Boktiteln");
        Console.Title = "01 Boktiteln";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Bok bok = new Bok();
        bok.Titel = "Kungskungen";
        bok.Forfattare = "Karlsson";
        Console.WriteLine($"Titel: {bok.Titel}, Forfattare: {bok.Forfattare}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}