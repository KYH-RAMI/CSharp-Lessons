
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 FraktFartyget");
        Console.Title = "11 FraktFartyget";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        // Skapa en 3x3-matris för arbetsschemat
        int[,] arbetsschema =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        string[] pass = { "Morgon", "Dag", "Natt" };

        Console.WriteLine("Före skiftbytet:");

        for (int i = 0; i < arbetsschema.GetLength(0); i++)
        {
            Console.Write($"{pass[i]}:\t");

            for (int j = 0; j < arbetsschema.GetLength(1); j++)
            {
                Console.Write(arbetsschema[i, j] + "\t");
            }

            Console.WriteLine();
        }

        for (int kolumn = 0; kolumn < arbetsschema.GetLength(1); kolumn++)
        {
            int temp = arbetsschema[0, kolumn];

            arbetsschema[0, kolumn] = arbetsschema[2, kolumn];

            arbetsschema[2, kolumn] = temp;
        }

        Console.WriteLine("\nEfter skiftbytet:");

        for (int i = 0; i < arbetsschema.GetLength(0); i++)
        {
            Console.Write($"{pass[i]}:\t");
            for (int j = 0; j < arbetsschema.GetLength(1); j++)
            {
                Console.Write(arbetsschema[i, j] + "\t");
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