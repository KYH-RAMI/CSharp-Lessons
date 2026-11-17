
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Radaravsökning");
        Console.Title = "06 Radavsökning";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        char[,] radar = new char[5, 5];
        radar[1, 3] = 'B';
        radar[4, 2] = 'K';
        for (int rad = 0; rad < radar.GetLength(0); rad++)
        {
            for (int kolumn = 0; kolumn < radar.GetLength(1); kolumn++)
            {
                if (radar[rad, kolumn] == 'B')
                {
                    Console.WriteLine($"Rad: {rad} Col: {kolumn}, {radar[rad, kolumn]}");
                }
                if (radar[rad, kolumn] == 'K')
                {
                    Console.WriteLine($"Rad: {rad} Col: {kolumn}, {radar[rad, kolumn]}");
                }



            }
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}