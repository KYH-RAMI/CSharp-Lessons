
class DieselMotor
{
    public void Starta()
    {
        Console.WriteLine("Försöker starta dieselmotorn...");
        // Simulera ett undantag som kan inträffa under startsekvensen
        Random random = new();
        if (Random.Shared.Next(0, 2) == 0) // 50% chans att kasta ett undantag
        {
            throw new Exception("Motorn kunde inte startas på grund av ett fel!");
        }
        Console.WriteLine("Dieselmotorn startade framgångsrikt.");
    }
    public void StangSakerhetsventil()
    {
        Console.WriteLine("Säkerhetsventilen stängs för att garantera säkerheten.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Kritiska-Motorn");
        Console.Title = "10 Kritiska-Motorn";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        DieselMotor motor = new DieselMotor();

        try
        {
            motor.Starta();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            motor.StangSakerhetsventil();
            Console.ResetColor();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}