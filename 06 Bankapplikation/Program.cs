namespace Bankapplikation;

public class BankKonto
{
   private decimal _saldo;

    public decimal Saldo
    {
        get => _saldo;
    }
    public void Insättning(decimal belopp)
    {
        if (belopp > 0)
        {
            this._saldo += belopp;
        }
        else
        {
            Console.WriteLine("Beloppet måste vara positivt.");       
        }
    }

    public void Uttag(decimal belopp)
    {
        if(belopp > this._saldo)
        {
            Console.WriteLine("Du har inte råd med så mycket pengar.");
        }
        this._saldo -= belopp;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Bankapplikation");
        Console.Title = "06 Bankapplikation";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        var konto = new BankKonto();
        Console.WriteLine($"Saldot: {konto.Saldo}");
        konto.Insättning(1000m);
        Console.WriteLine($"Insättning: 1000 kr");
        Console.WriteLine($"Ny Saldo: {konto.Saldo}");
        konto.Uttag(100m);
        Console.WriteLine($"Uttag: 100 kr");
        Console.WriteLine($"Ny Saldo: {konto.Saldo}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}