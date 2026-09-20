Console.WriteLine("08 Multiplikationstabellen");
Console.WriteLine("======================");
Console.WriteLine("\n");


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine();
    for (int j = 1; j <= 5; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();

}
Console.WriteLine("\n\n");
Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
