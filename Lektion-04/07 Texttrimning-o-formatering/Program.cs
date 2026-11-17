Console.WriteLine("07 Texttrimning och formatering");
Console.WriteLine("======================");
Console.Write("Hej, vad heter du? ");

string? namn = Console.ReadLine();

string råText = namn ?? "";
string trimmadText = råText.Trim();

Console.WriteLine($"Rå längd: {råText.Length}");
Console.WriteLine($"Trimmad längd: {trimmadText.Length}");
Console.WriteLine($"Skillnad: {råText.Length - trimmadText.Length} tecken");
Console.WriteLine($"Hej {trimmadText}!");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();