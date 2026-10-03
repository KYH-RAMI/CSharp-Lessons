
class Reskontra
{
    public int MatKostnad { get; set; }
    public int BränsleKostnad { get; set; }
    public Reskontra(int matKostnad, int bränsleKostnad)
    {
        MatKostnad = matKostnad;
        BränsleKostnad = bränsleKostnad;
    }
    public static Reskontra operator +(Reskontra r1, Reskontra r2) // Överlagring av + operatorn, nytt fenomen för mig!
    {
        return new Reskontra(r1.MatKostnad + r2.MatKostnad, r1.BränsleKostnad + r2.BränsleKostnad);
    }
    public void VisaStatus()
    {
        Console.ForegroundColor = ConsoleColor.Green;   
        Console.WriteLine($"Matkostnad: {MatKostnad:C}, Bränslekostnad: {BränsleKostnad:C}");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 Ekonomisk Reskontra");
        Console.Title = "07 Ekonomisk Reskontra";
        Console.WriteLine("=========================="); 
        Console.WriteLine();
        #endregion

        Reskontra vecka1 = new Reskontra(100, 200);
        Reskontra vecka2 = new Reskontra(150, 250);
        Reskontra total = vecka1 + vecka2;

        Console.WriteLine("Vecka 1:");
        vecka1.VisaStatus();

        Console.WriteLine("\nVecka 2:");
        vecka2.VisaStatus();

        Console.WriteLine("\nTotalt:");
        total.VisaStatus();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}