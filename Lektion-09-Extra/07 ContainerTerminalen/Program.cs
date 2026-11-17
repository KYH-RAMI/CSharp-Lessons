
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 Container Terminalen");
        Console.Title = "07 Container Terminalen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        int[,] containerTerminal =
        {
            { 10, 20, 30, 40 },
            { 50, 60, 70, 80 },
            { 90, 100, 110, 120 },
            { 130, 140, 150, 160 }
        };

        Console.WriteLine("Terminalen innehåller följande containrar:");

        for (int i = 0; i < containerTerminal.GetLength(0); i++)
        {
            for (int j = 0; j < containerTerminal.GetLength(1); j++)
            {
                Console.Write($"[{containerTerminal[i, j]}]\t");
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