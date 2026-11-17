
Console.WriteLine("07 Säker division (Ternary / Villkorsoperator)");
Console.WriteLine("======================");
Console.Write("Ange täljare: ");
double täljare = double.Parse(Console.ReadLine()!);

Console.Write("Ange nämnare: ");
double nämnare = double.Parse(Console.ReadLine()!);

string resultat = nämnare != 0 ? $"Resultat: {täljare / nämnare}" : "Resultat: 0! Fel: Nämnaren fick inte vara 0.";

Console.WriteLine(resultat);
Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 