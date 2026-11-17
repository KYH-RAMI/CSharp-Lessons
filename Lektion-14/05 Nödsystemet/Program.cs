
class Nödsignal
{
    public DateTime Tidsstempel { get; }

    public Nödsignal()
        => Tidsstempel = DateTime.Now;

    public virtual void VisaInfo()
        => Console.WriteLine($"Nödsignal skickad vid: {Tidsstempel:yyyy-MM-dd HH:mm:ss}");
}

class RadioAnrop : Nödsignal
{
    public int VhfKanal { get; }

    public RadioAnrop(int vhfKanal)
        => VhfKanal = vhfKanal;

    public override void VisaInfo()
    {
        base.VisaInfo();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Radioanrop");
        Console.ResetColor();

        Console.WriteLine($" på VHF-kanal: {VhfKanal}");
    }
}

class Nödraket : Nödsignal
{
    public string Färg { get; }

    public Nödraket(string färg)
        => Färg = färg;

    public override void VisaInfo()
    {
        base.VisaInfo();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nödraket");
        Console.ResetColor();

        Console.WriteLine($" med färg: {Färg}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Nödsystemet");
        Console.Title = "05 Nödsystemet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Nödsignal[] nödsignaler =
        [
            new RadioAnrop(16),
            new Nödraket("Röd")
        ];

        foreach (Nödsignal signal in nödsignaler)
        {
            signal.VisaInfo();
            Console.WriteLine();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}