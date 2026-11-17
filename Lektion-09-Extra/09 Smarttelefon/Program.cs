
class Smarttelefon
{
    public string Märke { get; set; }
    public string Färg { get; set; }

    public Smarttelefon(string märke, string färg)
    {
        Märke = märke;
        Färg = färg;
    }
    public Smarttelefon(string märke) : this (märke, "Svart") // this(parameter1, parameter2)
    {
        

    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("09 Smarttelefon");
        Console.Title = "09 Smarttelefon";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Console.ForegroundColor = ConsoleColor.Blue;
        Smarttelefon samsung = new Smarttelefon("Samsung", "Blå");
        Console.WriteLine($"Märke: {samsung.Märke}, Färg: {samsung.Färg}");
        Console.WriteLine();

        Smarttelefon apple = new Smarttelefon("Apple");
        Console.WriteLine($"Märke: {apple.Märke}, Färg: {apple.Färg}");
        Console.ResetColor();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}