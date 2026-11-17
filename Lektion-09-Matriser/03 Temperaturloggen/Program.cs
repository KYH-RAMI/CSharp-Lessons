class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Temperaturloggen");
        Console.Title = "03 Temperaturloggen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion


        int[,] temperaturer = new int[3, 2]
        {
            { -22, -18 },
            { -25, -21 },
            { -19, -20 }
        };

        int varmast = temperaturer[0, 0];
        int varmRad = 0;
        int varmCol = 0;

        for (int i = 0; i < temperaturer.GetLength(0); i++)
        {
            for (int j = 0; j < temperaturer.GetLength(1); j++)
            {
                if(temperaturer[i, j] > varmast)
                {
                    varmast = temperaturer[i, j];
                    varmRad = i;
                    varmCol = j;

                }
            }
        }
        Console.WriteLine($"Den varmaste temperatur är {varmast} grader. ");
        Console.WriteLine($"Varmaste punkten är i frys {varmRad}, mätpunkt nummer {varmCol}. ");


        #region footer
        Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion
}

}