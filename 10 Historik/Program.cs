
record Färdplan(int RuttID, string StartHamn, string DestinationHamn);

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Historik");
        Console.Title = "10 Historik";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Färdplan original = new Färdplan(
            1,
            "Stockholm",
            "Helsingfors");

        Färdplan uppdaterad = original with
        {
            DestinationHamn = "Tallinn"
        };

        Console.WriteLine("Original:");
        Console.WriteLine(original);

        Console.WriteLine();

        Console.WriteLine("Uppdaterad:");
        Console.WriteLine(uppdaterad);


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}