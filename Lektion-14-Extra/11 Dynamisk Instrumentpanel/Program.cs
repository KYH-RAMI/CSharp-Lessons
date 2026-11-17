
abstract class SkärmKomponent
{
    public abstract void Rita();
}
class DigitalKlocka : SkärmKomponent
{
    public override void Rita()
     => Console.WriteLine($"[KLOCKA] {DateTime.Now:HH:mm:ss}");
}
class KompassRos : SkärmKomponent
{
    public override void Rita()
    => Console.WriteLine("[KOMPASS] Kurs: 135° SE");
}
class EkolodGraf : SkärmKomponent
{
    public override void Rita()
    => Console.WriteLine("[EKOLOD] Djup: 42,7 m");
}
class Dashboard
{
    private readonly List<SkärmKomponent> _komponenter = [];

    public void LäggTill(SkärmKomponent komponent)
        => _komponenter.Add(komponent);

    public void UppdateraAlla()
    {
        Console.Clear();

        Console.WriteLine("11 - Dynamisk Instrumentpanel");
        Console.WriteLine("==========================");
        Console.WriteLine();

        foreach (SkärmKomponent komponent in _komponenter)
        {
            komponent.Rita();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        //Console.WriteLine("11 - Dynamisk Instrumentpanel");
        Console.Title = "11 - Dynamisk Instrumentpanel";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Dashboard dashboard = new Dashboard();

        dashboard.LäggTill(new DigitalKlocka());
        dashboard.LäggTill(new KompassRos());
        dashboard.LäggTill(new EkolodGraf());

        dashboard.UppdateraAlla();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}