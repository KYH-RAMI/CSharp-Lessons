#region header
Console.WriteLine("09 Betygskalkylatorn");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

string FastställBetyg(int poäng)
{
    if (poäng < 50)
        return "IG";

    if (poäng < 80)
        return "G";

    return "VG";
}

Console.WriteLine($"Du fick betyget {FastställBetyg(90)}");


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion