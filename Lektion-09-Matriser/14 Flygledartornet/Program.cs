
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Flygledartornet på skärgårdsflyget");
        Console.Title = "14 Flygledartornet på skärgårdsflyget";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        int[,] flygledarMatris =
           {
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 0, 1, 0 },
            { 0, 0, 0, 0 }
            };
        bool objektHittat = false;

        for (int i = 0; i < flygledarMatris.GetLength(0); i++)
        {
            if (flygledarMatris[i, i] == 1)
            {
                Console.WriteLine($"Objekt registrerat på koordinat [{i},{i}]");
                objektHittat = true;
            }
        }
        if (!objektHittat)
        {
            Console.WriteLine("Inga objekt hittades längs flygkorridoren.");
        }
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}