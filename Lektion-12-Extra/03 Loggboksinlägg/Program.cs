
record LoggInlägg(string Tidpunkt, string Händelse, string Väder);


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Loggboksinlägg");
        Console.Title = "03 Loggboksinlägg";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        LoggInlägg morgon = new LoggInlägg(
            "08:00",
            "Lämnade hamnen",
            "Klart väder"
        );
        LoggInlägg eftermiddag = morgon with {
            Tidpunkt = "15:00",
            Händelse = "Kommer tillbaka till hamnen"
        };

        LoggInlägg natt = morgon with {
            Tidpunkt = "22:00",
            Händelse = "Lämnade hamnen"
        };

        Console.WriteLine(morgon);
        Console.WriteLine(eftermiddag);
        Console.WriteLine(natt);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}