
record Loggboksinlägg(
    DateTime Tidsstämpel, 
    string Meddelande, 
    string Signatur);

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Låsta Loggboksinlägget");
        Console.Title = "04 Låsta Loggboksinlägget";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        Loggboksinlägg inlägg = new Loggboksinlägg(
            DateTime.Now,
            "Motor startad.",
            "Kapten");

        Console.WriteLine($"Tid: {inlägg.Tidsstämpel}");
        Console.WriteLine($"Meddelande: {inlägg.Meddelande}");
        Console.WriteLine($"Signatur: {inlägg.Signatur}");

        // inlägg.Meddelande = "Manipulerad text";
        // Kompileringsfel: Meddelande kan inte ändras direkt efter att objektet skapats.

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}