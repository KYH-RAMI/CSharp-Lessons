
class Bankkonto
{
    private decimal _saldo;
    public Bankkonto(decimal startSaldo)
    {
        if (startSaldo < 0)
        {
            _saldo = 0;
        }
        else
        {
            _saldo = startSaldo;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Kontot har skapats med startsaldo: {_saldo:C}");
        Console.WriteLine();
        Console.ResetColor();
    }
    public void SättIn(decimal belopp)
    {
        if (belopp > 0)
        {
            _saldo += belopp;
            Console.WriteLine($"Insättning: {belopp:C}. Nytt saldo: {_saldo:C}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Beloppet måste vara större än noll.");
            Console.WriteLine();
        }
    }
    public void TaUt(decimal belopp)
    {
        if (belopp > 0)
        {
            if (belopp <= _saldo)
            {
                _saldo -= belopp;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Uttag: {belopp:C}. Nytt saldo: {_saldo:C}");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Uttaget på {belopp:C} nekas. Tillgängligt saldo är {_saldo:C}.");
                Console.WriteLine();
                Console.ResetColor();   
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Beloppet måste vara större än noll.");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
    public decimal HämtaSaldo()
    {
        return _saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Bankkontot inkapsling");
        Console.Title = "02 Bankkontot inkapsling";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Bankkonto konto = new Bankkonto(1000m);
        
        Console.WriteLine($"Kontosaldo: {konto.HämtaSaldo():C}");
        
        Console.WriteLine($"Insättning: \n");
        konto.SättIn(500m);
        Console.WriteLine($"Uttag: \n");
        konto.TaUt(200m);
        Console.WriteLine($"Uttag: \n");
        konto.TaUt(1500m);

        Console.WriteLine($"Uttag: \n");
        konto.TaUt(0m);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}