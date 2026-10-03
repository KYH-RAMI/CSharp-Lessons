
class Fordon
{
    public virtual void Kör()
    {
        Console.WriteLine("Fordonet körs.");
    }
}
class Lastbil : Fordon
{
    public override void Kör()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("Lastbilens motor startar och den börjar köras.");
        Console.WriteLine();
        Console.ResetColor();
    }
}
class Gaffeltruck : Fordon
{
    public override void Kör()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("Gaffeltruckens motor startar och den börjar köras.");
        Console.WriteLine();
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 LogistikFordon (Polymorfism)");
        Console.Title = "05 LogistikFordon (Polymorfism)";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        List<Fordon> fordonLista = new List<Fordon>
        {
            new Lastbil(),
            new Gaffeltruck()
        };

        foreach (Fordon f in fordonLista)
        {
            f.Kör();
        }



        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}