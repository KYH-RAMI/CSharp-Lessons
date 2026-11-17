float fSum = 0;
decimal dSum = 0;

for (int i = 0; i < 10; i++)
{
    fSum += 0.1f;
    dSum += 0.1m;
}

Console.WriteLine($"Float:   {fSum:F20}");
Console.WriteLine($"Decimal: {dSum:F20}");

Console.WriteLine();
Console.WriteLine($"Är float exakt 1?   {fSum == 1.0f}");
Console.WriteLine($"Är decimal exakt 1? {dSum == 1.0m}");


Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();