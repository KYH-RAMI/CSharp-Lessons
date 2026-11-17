Console.WriteLine("12 Det kraschsäkra formuläret");
Console.WriteLine("======================");

double tal;

while (true)
{
    Console.Write("Mata in ett decimaltal: ");
    string? input = Console.ReadLine();

    if (double.TryParse(input, out tal))
    {
        break;
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Felaktig inmatning! Försök igen.");
    Console.ResetColor();
}

Console.WriteLine($"Korrekt! Du matade in: {tal}");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();