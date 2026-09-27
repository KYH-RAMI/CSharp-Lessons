#region header
Console.WriteLine("07 Sök i vektorn");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void City(string city)
{
    string[] Städer =
    {
        "Stockholm",
        "Göteborg",
        "Malmö",
        "Helsingborg",
        "Köpenhamn",
        "Oslo"
    };

    bool hittad = false;

    for (int i = 0; i < Städer.Length; i++)
    {
        if (Städer[i].Equals(city, StringComparison.OrdinalIgnoreCase)) // Ignorerar stora och små bokstäver 
        {
            Console.WriteLine($"Staden {city} finns på index {i}.");
            hittad = true;
            break;
        }
    }

    if (!hittad)
    {
        Console.WriteLine($"Staden {city} finns inte i listan.");
    }
}

Console.Write("Mata in en stad: ");
string input = Console.ReadLine() ?? "";

City(input);


#region footer
Console.WriteLine("\n\n==========================");
    Console.WriteLine("\nTryck på en tangent för att avsluta...");
    Console.ReadKey();
#endregion