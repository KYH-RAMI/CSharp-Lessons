
Console.Write("Ange visningsnamn: ");
string? visningsnamn = Console.ReadLine();

visningsnamn = string.IsNullOrWhiteSpace(visningsnamn) ? null : visningsnamn;

string användarnamn = "KalleKoda";

Console.WriteLine($"Välkommen, {visningsnamn ?? användarnamn ?? "Gäst"}!");


Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();