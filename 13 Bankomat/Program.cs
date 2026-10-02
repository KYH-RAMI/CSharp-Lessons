/// <summary>
/// Representerar ett bankkonto med inkapslad logik.
/// OBS: Uppgiften anger double för saldo och belopp.
/// Jag använder decimal eftersom klassen hanterar monetära värden
/// och decimal lämpar sig bättre för decimalbaserade ekonomiska beräkningar.
/// </summary>
/// <remarks>
/// Klassen hanterar insättningar och uttag från kontot.
/// </remarks>
/// <author>Rami</author>
/// <version>1.0</version>
/// <date>2026-10-02</date>
/// 
/// 
class Bankkonto
{
    private decimal _saldo;
    public Bankkonto(decimal startsaldo)
    {
        if (startsaldo < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Startsaldo kan inte vara negativt. Sätter saldo till 0. \n");
            _saldo = 0m;
            Console.ResetColor();
        }
        else
        {
            _saldo = startsaldo;
        }
    }
    public void SattIn(decimal belopp)
    {
        if (belopp < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Du kan inte sätta in ett negativt belopp. \n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _saldo += belopp;
            Console.WriteLine($"Du har satt in {belopp:C}. Nytt saldo: {_saldo:C}. \n");
            Console.ResetColor();
        }
    }
    public void TaUt(decimal belopp)
    {
        if (belopp < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Du kan inte ta ut ett negativt belopp. \n");
            Console.ResetColor();
        }
        else if (belopp > _saldo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Du kan inte ta ut mer än vad som finns på kontot. \n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _saldo -= belopp;
            Console.WriteLine($"Du har tagit ut {belopp:C}. Nytt saldo: {_saldo:C}. \n");
            Console.ResetColor();
        }
    }
    public decimal Saldo
    {
        get { return _saldo; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Bankomat med Inkapslad Logik");
        Console.Title = "13 Bankomat med Inkapslad Logik";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Bankkonto konto = new Bankkonto(1000m);
        konto.SattIn(499.99m);
        konto.TaUt(200m);
        konto.TaUt(1500m);
        Console.WriteLine();
        Console.WriteLine($"Nuvarande saldo: {konto.Saldo:C} ");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}