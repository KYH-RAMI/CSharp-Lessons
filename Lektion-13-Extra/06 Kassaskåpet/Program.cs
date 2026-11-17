
class Kassaskap
{
    private string _hemligKod;
    public Kassaskap(string initialKod)
    {
        _hemligKod = initialKod;
    }
    public bool UppdateraKod(string gammalKod, string nyKod)
    {
        if (string.IsNullOrWhiteSpace(nyKod))
        {
            return false;
        }

        if (gammalKod == _hemligKod)
        {
            _hemligKod = nyKod;
            return true;
        }

        return false;

    }
    public bool KontrolleraKod(string kod)
    {
        return kod == _hemligKod;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Det säkra kassaskåpet (Inkapsling med validering)");
        Console.Title = "06 Det säkra kassaskåpet (Inkapsling med validering)";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        var skåp = new Kassaskap("1234");

        Console.Write("Ange gammal kod: ");
        string gammalKod = Console.ReadLine() ?? "";

        Console.Write("Ange ny kod: ");
        string nyKod = Console.ReadLine() ?? "";
        bool ändrad = skåp.UppdateraKod(gammalKod, nyKod);

        Console.WriteLine($"Kodändring: {ändrad}");
        Console.WriteLine($"Kontrollera kod: {skåp.KontrolleraKod(nyKod)}");




        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}