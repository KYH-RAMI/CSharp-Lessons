Console.WriteLine("06 Säker-sifferinmatning");
Console.WriteLine("======================");
Console.Write("Vänligen mata in ett heltal: ");

string? heltal = Console.ReadLine();

if (int.TryParse(heltal, out int tal))
{
    Console.WriteLine($"Du matade in talet: {tal}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("FEL! Du måste ange ett heltal!!");
    Console.ResetColor();
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();