#region header
Console.WriteLine("12 Textformateraren (out)");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion


void DelaFullständigtNamn(
    string fulltNamn,
    out string förnamn,
    out string efternamn)
{
    if (fulltNamn.Contains(" "))
    { 
        /* 
        Allt efter första mellanslaget ska hamna i efternamn
        förnamn = fulltNamn.Substring(0, fulltNamn.IndexOf(" "));
        efternamn = fulltNamn.Substring(fulltNamn.IndexOf(" ") + 1);
        */

        // Dela strängen i 2 delar så resten av texten inte faller bort
        string[] delar = fulltNamn.Split(' ', 2); // 2 = max delar

        förnamn = delar[0];
        efternamn = delar[1];
    }
    else
    {
        förnamn = fulltNamn;
        efternamn = "Ej angivet";
    }
}

Console.Write("Ange ditt fullständiga namn: ");
string fulltNamn = Console.ReadLine() ?? "";
DelaFullständigtNamn(fulltNamn, out string förnamn, out string efternamn);
Console.WriteLine($"Förnamn: {förnamn}");
Console.WriteLine($"Efternamn: {efternamn}");
Console.WriteLine();

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion
