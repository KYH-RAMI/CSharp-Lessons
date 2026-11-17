const decimal vuxenPris = 120m;
const decimal rabattProcent = 10m;

Console.WriteLine("01 Biljettpriskalkylatorn");
Console.WriteLine("======================");
Console.WriteLine($"En vuxenbiljett kostar {vuxenPris} kr.");
Console.WriteLine($"Vid köp av minst 3 biljetter får du {rabattProcent}% rabatt på hela köpet.");
Console.Write("\nAnge antal biljetter: ");

if (int.TryParse(Console.ReadLine(), out int antalBiljetter) && antalBiljetter > 0)
{
    decimal totalPris = vuxenPris;
    totalPris *= antalBiljetter;

    Console.WriteLine("\n======== Summering ========");

    if (antalBiljetter >= 3)
    {
        
        decimal rabatt = totalPris * rabattProcent / 100;
        decimal slutPris = totalPris - rabatt;

        Console.WriteLine($"Antal biljetter: {antalBiljetter}");
        Console.WriteLine($"Ordinarie pris: {totalPris:F2} kr.");
        Console.WriteLine($"Rabatt ({rabattProcent}%): -{rabatt:F2} kr.");
        Console.WriteLine($"Slutpris: {slutPris:F2} kr.");
    }
    else
    {
        Console.WriteLine($"Antal biljetter: {antalBiljetter}");
        Console.WriteLine($"Ingen rabatt eftersom färre än 3 biljetter köptes.");
        Console.WriteLine($"Totalpris: {totalPris:F2} kr");
    }

    Console.WriteLine("============================");
}
else
{
    Console.WriteLine("\nVänligen försök igen! Endast positiva heltal tillåtna.");
}

Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 