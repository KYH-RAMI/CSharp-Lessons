string produktnamn = "Kaffebryggare";

decimal pris = 150.25m;

int antalILager = 10;

bool ärTillgänglig = antalILager > 0;

Console.WriteLine($"Produkt: {produktnamn}\nPris: {pris:C}kr\nLager: {antalILager}\nTillgänglig: {ärTillgänglig}");

Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();