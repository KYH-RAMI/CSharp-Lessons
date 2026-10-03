// LoggInlägg från tidigare uppgift, som ska användas i den generiska LastBox-klassen.
record LoggInlägg(string Tidpunkt, string Händelse, string Väder);
class LastBox<T>
{
    private T innehåll;
    public LastBox(T innehåll)
    {
        this.innehåll = innehåll;
    }
    public T HämtaInnehåll()
    {
        return innehåll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Den Generiska Lastboxen");
        Console.Title = "04 Den Generiska Lastboxen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        // Skapa en LastBox<string> för att förvara ett verktygsnamn, och en LastBox<LoggInlägg>
        // för att förvara ett digitalt loggblad. Hämta och skriv ut värdena.   
        LastBox<string> lastBox1 = new LastBox<string>("Hammar");

        LoggInlägg logg = new LoggInlägg(
            "08:00",
            "Lämnade hamnen",
            "Klart väder"
        );

        LastBox<LoggInlägg> lastBox2 =
            new LastBox<LoggInlägg>(logg);

        Console.WriteLine(lastBox1.HämtaInnehåll());
        Console.WriteLine(lastBox2.HämtaInnehåll());


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}