class Bankkonto
{
    private decimal _saldo;
    public decimal Saldo => _saldo;

    public void SättIn(decimal belopp)
    {
        if (belopp > 0)
        {
            _saldo += belopp;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel: Beloppet måste vara större än 0.");
            Console.ResetColor();
        }
    }

    //  Valde göra ytterligare metod med samma egenskaper om man skulle vilja ta ut pengar från kontot.
    public void Uttag(decimal belopp)
    {
        if (belopp > 0 && belopp <= _saldo)
        {
            _saldo -= belopp;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Felaktigt uttag!");
            Console.ResetColor();
        }
    }


}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Bankkonto");
        Console.Title = "06 Bankkonto";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

      Bankkonto bankkonto = new Bankkonto();

        //Saldon är 0
        Console.WriteLine($"Saldo: {bankkonto.Saldo}");

        //Saldo 100
        bankkonto.SättIn(100);
        Console.WriteLine($"Efter insättning: {bankkonto.Saldo}");
        
        //Efter uttag borde saldot vara 50
        bankkonto.Uttag(50);
        Console.WriteLine($"Saldo efter uttag: {bankkonto.Saldo}");


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}