class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Passageraröversikten");
        Console.Title = "02 Passageraröversikten";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        string[,] sittplatser = new string[4, 2];
        for (int rad = 0; rad < sittplatser.GetLength(0); rad++)
        {
            for (int stol = 0; stol < sittplatser.GetLength(1); stol++)
            {
                sittplatser[rad, stol] = "Ledig";
            }
        }

        sittplatser[0, 0] = "Rami";
        sittplatser[2, 1] = "Kalle";

        for (int rad = 0; rad < sittplatser.GetLength(0); rad++)
        {
            for (int stol = 0; stol < sittplatser.GetLength(1); stol++)
            {
                Console.Write($"Rad {rad}, Stol {stol}: {sittplatser[rad, stol]}");
            }
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}