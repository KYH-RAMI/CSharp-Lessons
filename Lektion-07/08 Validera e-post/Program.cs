#region header
Console.WriteLine("08 Validera e-post");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

bool ÄrGiltigEpost(string epost)
{
    return epost.Contains("@") &&
           epost.Contains(".") &&
           epost.Length >= 5;
}


bool ärGiltig = ÄrGiltigEpost("kalle@kalle.se");

if(ärGiltig)
{
    Console.WriteLine("E-posten är giltig");
}
else
{
    Console.WriteLine("E-posten är ogiltig");
}

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion
