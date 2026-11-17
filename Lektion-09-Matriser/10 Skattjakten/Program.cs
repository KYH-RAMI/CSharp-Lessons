
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Skattjakten");
        Console.Title = "10 Skattjakten";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        // Skapa en 3x3 matris fylld med vågor
        char[,] ocean = new char[3, 3];

        Console.WriteLine("Havet:");

        for (int i = 0; i < ocean.GetLength(0); i++)
        {
            for (int j = 0; j < ocean.GetLength(1); j++)
            {
                Console.Write("~ ");
            }

            Console.WriteLine();
        }
        // Placera skatten
        ocean[1, 2] = 'X';

        // Gissa på skatten
        Console.Write("Mata in en rad (0-2): ");
        int rad = int.Parse(Console.ReadLine());

        Console.Write("Mata in en kolumn (0-2): ");
        int kolumn = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (ocean[rad, kolumn] == 'X')
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du träffade skatten!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Du hamnade i vattnet!");
            Console.ResetColor();
        }
        Console.WriteLine("\nResultat:");

        for (int i = 0; i < ocean.GetLength(0); i++)
        {
            for (int j = 0; j < ocean.GetLength(1); j++)
            {
                if (i == rad && j == kolumn)
                {
                    if (ocean[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("O ");
                    }

                    Console.ResetColor();
                }
                else
                {
                    Console.Write("~ ");
                }
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