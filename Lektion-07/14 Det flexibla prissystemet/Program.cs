#region header
Console.WriteLine("14 Det flexibla prissystemet");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

// params gör att metoden kan ta emot valfritt antal decimalvärden,
// som sedan behandlas som en decimal-array inne i metoden.
decimal BeräknaTotalPris(
    decimal rabattSats, 
    params decimal[] produktPriser)
{
    decimal summa = 0;

    foreach(decimal pris in produktPriser)
    {
        summa += pris;
    }
    
    return summa * (1 - rabattSats);

}

decimal rabatt = 0.10m;

Console.WriteLine($"Rabatt: {rabatt:P2}, Total: {BeräknaTotalPris(rabatt, 100m, 200m):C}");
Console.WriteLine($"Rabatt: {rabatt:P2}, Total: {BeräknaTotalPris(rabatt, 100m, 200m, 300m, 500m, 400m):C}");
Console.WriteLine($"Rabatt: {rabatt:P2}, Total: {BeräknaTotalPris(rabatt):C}");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion