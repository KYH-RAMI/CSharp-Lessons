
class Bransletank
{
    public static int AvläsProcent(int liter, int maxLiter)
    {
        if (liter > maxLiter)
        {
            throw new ArgumentOutOfRangeException(
                nameof(liter),
                $"Liter ({liter}) får inte överstiga tankens maxkapacitet ({maxLiter}).");
        }

        return (int)((double)liter / maxLiter * 100);
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Säker bränslemätare");
        Console.Title = "02 Säker bränslemätare";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        try
        {
            int procent = Bransletank.AvläsProcent(70, 60);

            Console.WriteLine($"Bränslenivå: {procent}%");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}