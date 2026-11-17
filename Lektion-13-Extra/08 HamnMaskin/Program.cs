
abstract class Hamnmaskin
{
    public abstract double EffektKw { get; }
    public abstract void Starta();

}
class Kran : Hamnmaskin
{
    public override double EffektKw { get; }

    public Kran(double effektKw)
        => EffektKw = effektKw;

    public override void Starta()
        => Console.WriteLine($"Kranen startar med en effekt på {EffektKw} kW.");
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Hamnmaskin");
        Console.Title = "08 Hamnmaskin";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Hamnmaskin kran = new Kran(100);
        kran.Starta();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}