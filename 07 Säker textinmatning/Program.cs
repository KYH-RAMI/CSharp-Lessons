#region header
Console.WriteLine("07 Säker textinmatning");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

string LäsSäkerText(string ledtext)
{
    while (true)
    {
        Console.Write(ledtext);
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Du måste skriva något.");
            continue;
        }

        return input;
    }
}

string text = LäsSäkerText("Skriv in något: ");
Console.WriteLine($"Du skrev: {text}");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion