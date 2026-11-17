
Console.WriteLine("04 Godisdelaren ");
Console.WriteLine("======================");
int antalGodisar = 23;
int antalPersoner = 4;

int godisarPerPerson = antalGodisar / antalPersoner;
int godisarÖver = antalGodisar % antalPersoner;

Console.WriteLine($"Varje person får {godisarPerPerson} godisar.");
Console.WriteLine($"Det blir {godisarÖver} godisar över.");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 