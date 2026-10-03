
class Notifiering
{
    public string Innehåll { get; set; }
    public Notifiering(string innehåll)
    {
        Innehåll = innehåll;
    }
    public virtual void Skicka()
    {
        Console.WriteLine($"Notifiering: {Innehåll}");
    }
}

class SmsNotifiering : Notifiering
{
    public SmsNotifiering(string innehåll) : base(innehåll) { }
    public override void Skicka()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"[SMS] {Innehåll}");
        Console.WriteLine();
        Console.ResetColor();
    }
}

class EpostNotifiering : Notifiering
{
    public EpostNotifiering(string innehåll) : base(innehåll) { }
    public override void Skicka()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine();
        Console.WriteLine($"[E-POST] {Innehåll}");
        Console.WriteLine();
        Console.ResetColor();
    }
}

class Program
{
    static void HanteraNotifieringar(Notifiering[] notifieringar)
    {
        foreach (Notifiering notifiering in notifieringar)
        {
            notifiering.Skicka();
        }
    }
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 MeddelandeSystemet");
        Console.Title = "09 MeddelandeSystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        // Modern C# collection expression syntax
        Notifiering[] notifieringar =
        [
            new EpostNotifiering("Din beställning är godkänd."),
            new SmsNotifiering("Paketet har skickats."),
            new EpostNotifiering("Din faktura finns nu tillgänglig."),
            new SmsNotifiering("Leveransen är på väg.")
        ];

        HanteraNotifieringar(notifieringar);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}


