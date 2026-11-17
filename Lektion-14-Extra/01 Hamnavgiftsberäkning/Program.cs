
class Fartyg
{
    public virtual string BeräknaBasavgift() => "Standard tariff";
}

class Yacht : Fartyg
{
    public override string BeräknaBasavgift() => "Hög tariff";
}
class Fiskebåt : Fartyg
{
    public override string BeräknaBasavgift() => "Reducerad tariff";
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Hamnavgiftsberäkning");
        Console.Title = "01 Hamnavgiftsberäkning";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Fartyg[] fartyg =
        [
            new Fartyg(),
            new Yacht(),
            new Fiskebåt()
        ];

        foreach (Fartyg f in fartyg)
        {
            string tariff = f.BeräknaBasavgift();

            ConsoleColor färg = tariff switch
            {
                "Hög tariff" => ConsoleColor.Red,
                "Reducerad tariff" => ConsoleColor.Green,
                _ => ConsoleColor.Yellow
            };

            Console.Write($"[{f.GetType().Name,-10}] Basavgift: ");

            Console.ForegroundColor = färg;
            Console.WriteLine(tariff);
            Console.ResetColor();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}