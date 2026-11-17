Console.WriteLine("08 Dynamisk titelbar");
Console.WriteLine("======================");
Console.WriteLine("Skriv något: ");

string input = Console.ReadLine() ?? "Min konsol";

Console.Title = input;

Console.WriteLine($"Du skrev: {input}");
Console.WriteLine("Kolla nu titeln på fönstret.");

Console.WriteLine("======================");
Console.WriteLine("Tryck på en tangent för att avsluta...");
Console.ReadKey();