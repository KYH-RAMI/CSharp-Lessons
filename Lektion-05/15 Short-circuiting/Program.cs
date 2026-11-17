
Console.WriteLine("15 Short-circuiting som logisk grindvakt (Garanterad säkerhet)");
Console.WriteLine("====================");

string? str = null;

if (str != null && str.Length > 5)
{
    Console.WriteLine("Strängen är inte null och har mer än 5 tecken.");
}
else
{
    Console.WriteLine("Strängen är null eller har inte mer än 5 tecken.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
// Förklaring:
// Villkoret str != null && str.Length > 5 är en logisk grindvakt.
// Detta betyder att villkoret str.Length > 5 endast kontrolleras om str != null är true.
// Villkoret str != null kontrolleras först.
// Om det är false, villkoret str.Length > 5 behöver inte kontrolleras och programmet kraschar inte.
// Villkoret str.Length > 5 kontrolleras endast om str != null är true.
// Detta är viktigt för att garantera säkerhet och undvika NullReferenceException.