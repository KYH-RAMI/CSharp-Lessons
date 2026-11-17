Console.WriteLine("03 Temperaturvarnaren");
Console.WriteLine("======================");
Console.Write("Mata in dagens temperatur: ");

string? msg = Console.ReadLine();

if (double.TryParse(msg, out double temperature))
{
    if (temperature < 0.0)
    {
        Console.WriteLine("\nDet är minusgrader ute.");
    }
    else
    {
        Console.WriteLine("\nDet är plusgrader eller nollgradigt.");
    }
}
else
{
    Console.WriteLine("\nFelaktig inmatning.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();