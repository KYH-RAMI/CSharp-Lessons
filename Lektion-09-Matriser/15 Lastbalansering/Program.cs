
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Lastbalansering på fraktfärjan");
        Console.Title = "15 Lastbalansering på fraktfärjan";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        int[,] vikter =
        {
            { 1200, 1100, 900, 1000 },
            { 1000, 1300, 1100, 1200 },
            { 900, 1000, 1200, 1100 },
            { 1100, 900, 1000, 1300 }
        };

        int babord = 0;
        int styrbord = 0;

        for (int i = 0; i < vikter.GetLength(0); i++)
        {
            for (int j = 0; j < vikter.GetLength(1); j++)
            {
                if (j < 2)
                {
                    babord += vikter[i, j];
                }
                else
                {
                    styrbord += vikter[i, j];

                }
            }
        }
        int diff = Math.Abs(babord - styrbord);

        if (babord > styrbord)
        {
            Console.WriteLine($"Babord är {diff} kg tyngre. \n");
        }
        else if (styrbord > babord)
        {
            Console.WriteLine($"Styrbord är {diff} kg tyngre. \n");
        }
        else
        {
            Console.WriteLine("Färjan är perfekt balanserad! \n");
        }
        Console.WriteLine("Rapport: ");
        Console.WriteLine($"Babord: {babord} kg");
        Console.WriteLine($"Styrbord: {styrbord} kg");
        Console.WriteLine($"Skillnad: {diff} kg");





        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}