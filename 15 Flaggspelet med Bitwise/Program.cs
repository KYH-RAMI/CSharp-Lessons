Console.WriteLine("15 Flaggspelet med Bitwise");
Console.WriteLine("==========================");
Console.WriteLine();

byte status = 0;

for (int i = 0; i < 8; i++)
{
    if (i == 1 || i == 3 || i == 5)
    {
        if (i == 1)
        {
            status |= 1;
        }
        else if (i == 3)
        {
            status |= 2;
        }
        else if (i == 5)
        {
            status |= 4;
        }
    }
    else if (i == 2 || i == 4 || i == 6)
    {
        continue;
    }
    else if (i == 7)
    {
        status = (byte)(status & ~2);
    }
    Console.WriteLine($"i = {i} -> status = {status}");
}

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();


