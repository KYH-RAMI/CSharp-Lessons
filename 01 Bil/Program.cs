class Bil
{
    public string? modell;
    public int? årsmodell;
}

internal class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("01 Bil");
        Console.Title = "01 Bil";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Bil bil1 = new Bil();
        bil1.modell = "Volvo V60";
        bil1.årsmodell = 2023;

        Bil bil2 = new Bil();
        bil2.modell = "Volvo V90";
        bil2.årsmodell = 2026;

        Console.WriteLine($"{bil1.modell} {bil1.årsmodell}");
        Console.WriteLine($"{bil2.modell} {bil2.årsmodell}");


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}