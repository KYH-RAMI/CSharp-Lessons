
Console.WriteLine("06 Medlemsrabatt");
Console.WriteLine("======================");

bool ärGuldmedlem = false;
int ålder = 66;
decimal köpbelopp = 501m;

bool fårRabatt = ärGuldmedlem || (ålder > 65 && köpbelopp > 500);

Console.WriteLine($"Kunden får rabatt: {fårRabatt}");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 