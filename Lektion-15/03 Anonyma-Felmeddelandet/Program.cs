
class Program
{
    static void LasKansligFil(string sokvag)
    {
        try
        {
            // Logik för att läsa filen
            string innehall = File.ReadAllText(sokvag);
            Console.WriteLine("Fil: " + sokvag + " har lästs in");  

        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ett internt systemfel uppstod. Åtgärden kunde inte slutföras.");
            Console.ResetColor();
        }
    }

    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Anonyma Felmeddelandet");
        Console.Title = "03 Anonyma Felmeddelandet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        LasKansligFil("hemligfil.txt");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}