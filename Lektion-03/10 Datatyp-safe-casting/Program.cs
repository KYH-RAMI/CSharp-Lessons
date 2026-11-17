
Console.WriteLine("10 Datatyp-safe-casting (is & as)");
Console.WriteLine("======================");

object input = "123";

string? text = input as string;

Console.WriteLine($"Är input en string: {input is string}");
Console.WriteLine($"Konvertering lyckades: {text is not null}");
Console.WriteLine($"Värde: {text ?? "null"}");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();   