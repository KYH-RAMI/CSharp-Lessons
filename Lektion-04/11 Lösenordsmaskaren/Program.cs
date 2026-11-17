Console.WriteLine("11 Lösenordsmaskaren");
Console.WriteLine("======================");
Console.Write("Ange lösenord: ");

string lösenord = "";

while (true)
{
    ConsoleKeyInfo tangent = Console.ReadKey(true);

    if (tangent.Key == ConsoleKey.Enter)
    {
        break;
    }
    else if (tangent.Key == ConsoleKey.Backspace)
    {
        if (lösenord.Length > 0)
        {
            lösenord = lösenord[..^1];
            Console.Write("\b \b");
        }
    }
    else
    {
        lösenord += tangent.KeyChar;
        Console.Write("*");
    }
}

Console.WriteLine();
Console.WriteLine($"Du försökte mata in: {lösenord}");
Console.WriteLine($"Lösenordet innehåller {lösenord.Length} tecken.");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();