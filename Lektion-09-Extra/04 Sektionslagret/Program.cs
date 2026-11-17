
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Sektionslagret");
        Console.Title = "04 Sektionslagret";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        int[,] paket = new int[3, 4] 
        { 
            { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 } 
        };

        int summa = 0;

        Console.WriteLine();
        for (int i = 0; i < paket.GetLength(1); i++)
        {
            summa += paket[1, i];
        }
        Console.WriteLine($"Summan av paket i andra raden är: {summa}");
        Console.WriteLine();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}