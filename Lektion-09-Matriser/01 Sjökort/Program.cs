class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Sjökort");
        Console.Title = "01 Sjökort";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string[,] sjökort = new string[3, 3]
        {
            {"Öppet hav", "Klippa",    "Öppet hav" },
            {"Öppet hav", "Ö",         "Klippa" },
            {"Grund",     "Öppet hav", "Öppet hav" }
        };

        string mittRuta = sjökort[1, 1];
        Console.WriteLine($"Innehåll i mittrutan: {mittRuta}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}