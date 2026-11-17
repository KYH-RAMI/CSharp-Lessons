#region header
Console.WriteLine("01 Namnlistan");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion


string[] NamnListan = new string[5]
{
    "RoRo",
    "Rami",
    "Koko",
    "Bobo",
    "Blueie"
};

Console.WriteLine($"Första namnet: {NamnListan[0]}");
Console.WriteLine($"Sista namnet: {NamnListan[NamnListan.Length - 1]}");


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion