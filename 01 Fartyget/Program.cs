
class Fartyg
{
    public string Namn { get; set; }
    public double Längd { get; set; }
    public Fartyg(string namn, double längd)
    {
        Namn = namn;
        Längd = längd;
    }
    public virtual void VisaInfo()
    {
        Console.WriteLine($"Fartyg: {Namn}, Längd: {Längd} meter");
    }
}
class Segelbåt : Fartyg
{
    public double Mastlängd { get; set; }
    public Segelbåt(string namn, double längd, double mastlängd) : base(namn, längd)
    {
        Mastlängd = mastlängd;
    }
    public override void VisaInfo()
    {
        Console.WriteLine($"Segelbåt: {Namn}, Längd: {Längd} meter, Mastlängd: {Mastlängd} meter");
    }
}       

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Fartyget");
        Console.Title = "01 Fartyget";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Fartyg fartyg = new Fartyg("Fartyg", 100);
        fartyg.VisaInfo();

        Segelbåt segelbåt = new Segelbåt("Segelbåt", 50, 20);
        segelbåt.VisaInfo();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}