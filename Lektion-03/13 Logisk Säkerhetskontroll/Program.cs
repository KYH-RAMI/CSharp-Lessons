
Console.WriteLine("13 Logisk 'Short-circuiting' (Säkerhetskontroll)");
Console.WriteLine("======================");

bool förstaVillkor = false;

Console.WriteLine("Test med &&:");
bool resultat1 = förstaVillkor && Kontrollera();
Console.WriteLine($"Resultat: {resultat1}");

Console.WriteLine("\nTest med &:");
bool resultat2 = förstaVillkor & Kontrollera();
Console.WriteLine($"Resultat: {resultat2}");

static bool Kontrollera()
{
    Console.WriteLine("Kontrollera() kördes!");
    return true;
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 