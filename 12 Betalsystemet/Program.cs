
abstract class Betalning
{
    private decimal _belopp;
    public decimal Belopp
    {
        get => _belopp;
        set
        {
            if (value < 0)
                throw new ArgumentException("Beloppet får inte vara negativt. \n");
            _belopp = value;
        }
    }
    public Betalning(decimal belopp)
    {
        Belopp = belopp; 
    }
    public abstract void GenomförTransaktion();
}
class Kortbetalning : Betalning
{
    public Kortbetalning(decimal belopp) : base(belopp) { }
    public override void GenomförTransaktion() => Console.WriteLine($"Kortbetalning genomförd: {Belopp:C} har dragits från kortet. \n");
}
class SwishBetalning : Betalning
{
    public SwishBetalning(decimal belopp) : base(belopp) { }
    public override void GenomförTransaktion() => Console.WriteLine($"Swishbetalning genomförd: {Belopp:C} har skickats via Swish. \n");
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 Betalsystemet");
        Console.Title = "12 Betalsystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        List<Betalning> betalningar =
        [
            new Kortbetalning(150.75m),
            new SwishBetalning(200.00m),
            new Kortbetalning(50.25m),
            new SwishBetalning(300.00m)
        ];

        foreach (var betalning in betalningar)
        {
            betalning.GenomförTransaktion();
        }
        try
        {
            Betalning felBetalning = new Kortbetalning(-50m);
        }
        catch (ArgumentException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}