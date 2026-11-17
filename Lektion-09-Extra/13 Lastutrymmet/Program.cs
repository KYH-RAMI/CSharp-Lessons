
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Lastutrymmet");
        Console.Title = "13 Lastutrymmet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string[,] lastutrymme =
{
    { "ABC123", "DEF456", "GHI789" },
    { "JKL012", "MNO345", "PQR678" },
    { "STU901", "VWX234", "YZA567" }
};

        string[,] nyttLastutrymme = new string[5, 5];

        // Fyll hela nya matrisen med "Tom"
        for (int i = 0; i < nyttLastutrymme.GetLength(0); i++)
        {
            for (int j = 0; j < nyttLastutrymme.GetLength(1); j++)
            {
                nyttLastutrymme[i, j] = "Tom";
            }
        }

        // Kopiera gamla matrisen till den nya
        for (int i = 0; i < lastutrymme.GetLength(0); i++)
        {
            for (int j = 0; j < lastutrymme.GetLength(1); j++)
            {
                nyttLastutrymme[i, j] = lastutrymme[i, j];
            }
        }

        // Skriv ut den nya matrisen
        for (int i = 0; i < nyttLastutrymme.GetLength(0); i++)
        {
            for (int j = 0; j < nyttLastutrymme.GetLength(1); j++)
            {
                Console.Write($"{nyttLastutrymme[i, j],-8}");
            }
            Console.WriteLine();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}