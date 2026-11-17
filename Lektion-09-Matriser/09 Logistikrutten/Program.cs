
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 Logistikrutten");
        Console.Title = "09 Logistikrutten";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string[,] hyllor = new string[6, 6];
        bool hittad = false;
        int pallNummer = 100;

        for (int i = 0; i < hyllor.GetLength(0); i++)
        {
            for (int j = 0; j < hyllor.GetLength(1); j++)
            {
                hyllor[i, j] = $"PALL-{pallNummer}";
                pallNummer++;
            }
        }

        Console.Write("Ange pallnummer: ");

        string SökID = Console.ReadLine()?.Trim().ToUpper() ?? "";

        if (!SökID.StartsWith("PALL-"))
        {
            SökID = "PALL-" + SökID;
        }
        Console.WriteLine();
        for (int i = 0; i < hyllor.GetLength(0) && !hittad; i++)
        {
            for (int j = 0; j < hyllor.GetLength(1); j++)
            {
                if (hyllor[i, j] == SökID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Pall {SökID} finns på hylla {i + 1}, plats {j + 1}.");
                    Console.ResetColor();
                    hittad = true;
                    break;
                }
            }
        }
        if (!hittad)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pall hittades inte!");
            Console.ResetColor();
        }       
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}