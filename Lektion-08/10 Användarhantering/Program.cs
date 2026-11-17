#region header
Console.WriteLine("10 Användarhantering");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

//Modern C# List Array 
List<string> AnvändarNamn = new()
{
    "Kalle",
    "Eko",
    "RoRo",
    "Rami",
    "Bobo"
};




Console.Write("Mata in ett användarnamn du vill ta bort: ");
string input = Console.ReadLine() ?? "";

if (AnvändarNamn.Remove(input))
{
    Console.WriteLine($"{input} har tagits bort från användarnamnen.");
    Console.WriteLine("\nUppdaterad lista: ");

    foreach (string namn in AnvändarNamn)
    {
        Console.WriteLine(namn);
    }
}
else
{
    Console.WriteLine("\n\nAnvändarnamnet kunde inte hittas.");
}


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion