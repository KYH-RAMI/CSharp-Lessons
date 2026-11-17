namespace Lektion13.Uppgift02;

public static class Uppgift02Demo
{
    public static void Kör()
    {
        Katt katt = new Katt("Sushi");
        Console.WriteLine("=== Uppgift 2: Djur/Katt ===");
        Console.WriteLine();
        Console.WriteLine(katt);
        Console.WriteLine($"Kattens namn: {katt.Namn}");
        Console.WriteLine(katt.GetType().Name);
        Console.WriteLine(katt.GetType().FullName);
        Console.WriteLine(katt.GetType().BaseType);
        Console.WriteLine(typeof(Djur).Name); // Djur
        Console.WriteLine(katt.GetType().Name); // Katt
        /*
        Katt katt = new Katt("Sushi");

        Djur djur = katt;

        Console.WriteLine(typeof(Djur).Name);
        Console.WriteLine(djur.GetType().Name);
        */

    }
}
