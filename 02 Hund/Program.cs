class Hund
{
    public string namn;
    public string ras;

    public Hund(string namn, string ras)
    {
        this.namn = namn;
        this.ras = ras;
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("02 Hund");
        Console.Title = "02 Hund";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Hund Hund1 = new Hund("Fido", "Husky");
        Hund Hund2 = new Hund("Rex", "Labrador");

        Console.WriteLine($"Hund1: {Hund1.namn} är av rasen {Hund1.ras}");

        Console.WriteLine($"Hund2: {Hund2.namn} är av rasen {Hund2.ras}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}