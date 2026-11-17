string förnamn = "John";
string? mellannamn = null; // Efternamn är null
int? partnernsÅlder = null; // Partnerns ålder är null
Console.WriteLine($"Namn: {förnamn} {mellannamn}");

if (partnernsÅlder.HasValue)
{
    Console.WriteLine($"Partnerns ålder: {partnernsÅlder.Value}");
}
else
{
    Console.WriteLine("Partnerns ålder: Inte angivet");
}

Console.WriteLine($"Partnerns ålder: {(partnernsÅlder.HasValue ? partnernsÅlder.Value.ToString() : "Inte angivet")}");



Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();