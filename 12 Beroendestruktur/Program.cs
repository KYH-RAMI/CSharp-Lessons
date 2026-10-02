
class Batteri
{
    public int KapacitetProcent { get; set; }
}

class Mobiltelefon
{
    public string Modell { get; set; }
    public Batteri TelefonBatteri { get; set; }

    public Mobiltelefon(string modell, Batteri telefonBatteri)
    {
        Modell = modell;
        TelefonBatteri = telefonBatteri;
    }
    public void VisaStatus()
    {
        Console.WriteLine();
        Console.WriteLine("Status på telefonen: \n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Modell: {Modell}");
        Console.WriteLine($"Batterikapacitet: {TelefonBatteri.KapacitetProcent}%");
        Console.ResetColor();
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 Beroendestruktur");
        Console.Title = "12 Beroendestruktur";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion


        Mobiltelefon mobiltelefon1 = new Mobiltelefon("iPhone 18 Pro Max", new Batteri { KapacitetProcent = 100 });
        mobiltelefon1.VisaStatus();
        Mobiltelefon mobiltelefon2 = new Mobiltelefon("Samsung Galaxy S23 Ultra", new Batteri { KapacitetProcent = 75 });   
        mobiltelefon2.VisaStatus();
       


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}

       