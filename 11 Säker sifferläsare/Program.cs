#region header
Console.WriteLine("11 Säker sifferläsare");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

int LäsHeltal(string ledtext, int min, int max)
{
    while (true)
    {
        Console.Write(ledtext);
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int talet))
        {
            Console.WriteLine("Du måste ange ett giltigt heltal.");
            continue;
        }

        if (talet < min || talet > max)
        {
            Console.WriteLine($"Talet måste vara mellan {min} och {max}.");
            continue;
        }

        return talet;
    }
}

int tal = LäsHeltal("Ange ett tal mellan 1 och 10: ", 1, 10);
Console.WriteLine();

Console.WriteLine($"Du matade in: {tal}");


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion