namespace Lektion13.Uppgift01;

public static class Uppgift01Demo
{
    public static void Kör()
    {
        Bil b1 = new Bil("Volvo", 4);
        Console.WriteLine("=== Uppgift 1: Fordon/Bilb ===");
        Console.WriteLine();
        Console.WriteLine($"Märke: {b1.Märke}");
        Console.WriteLine($"Antal dörrar: {b1.AntalDörrar}");
    }
}
