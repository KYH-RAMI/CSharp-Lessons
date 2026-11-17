#region header
Console.WriteLine("05 Tärningskastet");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion


int KastaTärning()
{
    Random slump = new Random();
    int tärning = slump.Next(1, 7);

    return tärning;
}

Console.WriteLine($"Du kastade tärningen och fick en {KastaTärning()}");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion