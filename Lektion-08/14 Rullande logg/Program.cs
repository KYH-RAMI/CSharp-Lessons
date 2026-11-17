#region header
Console.WriteLine("14 Rullande logg");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion
/*
 * 
 * 
 * Inte enkel uppgift. Behövde Assist med uppgiften... 
 * 
 * Kärnlösning: 
 * logg[i] = logg[i + 1];
 * och logg[logg.Length - 1] = nyttMeddelande;
 * 
 */

string[] logg = new string[5];

void LäggTillLogg(string[] logg, string nyttMeddelande)
{
    for (int i = 0; i < logg.Length; i++)
    {
        if (string.IsNullOrEmpty(logg[i]))
        {
            logg[i] = nyttMeddelande;
            return;
        }
    }

    for (int i = 0; i < logg.Length - 1; i++)
    {
        logg[i] = logg[i + 1];
    }

    logg[logg.Length - 1] = nyttMeddelande;
}

for (int i = 0; i < 7; i++)
{
    Console.Write("Mata in ett meddelande: ");
    string input = Console.ReadLine() ?? "";

    LäggTillLogg(logg, input);
}

Console.WriteLine("\nAktuell logg:");

foreach (string meddelande in logg)
{
    Console.WriteLine(meddelande);
}


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion