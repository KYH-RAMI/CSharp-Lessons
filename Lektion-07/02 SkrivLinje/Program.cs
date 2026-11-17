#region header
Console.WriteLine("02 SkrivLinje");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void SkrivAvskiljare()
{
    for (int i = 0; i < 30; i++)
    {
        Console.Write("*");
    }
}

SkrivAvskiljare();
Console.WriteLine();
Console.WriteLine("Hej, och hoj!");
SkrivAvskiljare();
Console.WriteLine();
Console.WriteLine("Jag börjar gilla C# väldigt mycket! Trodde jag skulle hata den som pesten (C++) men nope ;D ");
SkrivAvskiljare();
Console.WriteLine();

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion