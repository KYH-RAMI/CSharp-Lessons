Console.WriteLine("03 Tecken-speglingen");
Console.WriteLine("======================");
Console.WriteLine("Skriv in en text: ");
ConsoleKeyInfo key = Console.ReadKey(true);
Console.WriteLine($"Du tryckte på {key.KeyChar}");
Console.WriteLine($"Tangentkod: {key.Key}");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();