
abstract class FartygsKomponent
{
    public string Namn { get; }

    protected FartygsKomponent(string namn)
        => Namn = namn;

    public abstract void VisaStruktur(int indrag);
}

class EnskildDel : FartygsKomponent
{
    public EnskildDel(string namn) : base(namn) { }

    public override void VisaStruktur(int indrag)
        => Console.WriteLine($"{new string(' ', indrag)}└── {Namn}");
}

class SammansattDel : FartygsKomponent
{
    private readonly List<FartygsKomponent> _underdelar = [];

    public SammansattDel(string namn) : base(namn) { }

    public void LäggTillUnderdel(FartygsKomponent komponent)
        => _underdelar.Add(komponent);

    public override void VisaStruktur(int indrag)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{new string(' ', indrag)}+ {Namn}");
        Console.ResetColor();

        foreach (FartygsKomponent underdel in _underdelar)
        {
            underdel.VisaStruktur(indrag + 4);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("15 Fartygsdelar");
        Console.Title = "15 Fartygsdelar";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        SammansattDel fartyg = new SammansattDel("Fartyg");

        SammansattDel motor = new SammansattDel("Motor");
        motor.LäggTillUnderdel(new EnskildDel("Kolv"));
        motor.LäggTillUnderdel(new EnskildDel("Tändstift"));

        SammansattDel bränslesystem = new SammansattDel("Bränslesystem");
        bränslesystem.LäggTillUnderdel(new EnskildDel("Bränslepump"));
        bränslesystem.LäggTillUnderdel(new EnskildDel("Bränslefilter"));

        motor.LäggTillUnderdel(bränslesystem);

        SammansattDel styrsystem = new SammansattDel("Styrsystem");
        styrsystem.LäggTillUnderdel(new EnskildDel("Ratt"));
        styrsystem.LäggTillUnderdel(new EnskildDel("Roder"));

        fartyg.LäggTillUnderdel(motor);
        fartyg.LäggTillUnderdel(styrsystem);
        fartyg.LäggTillUnderdel(new EnskildDel("Ankare"));

        fartyg.VisaStruktur(0);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}