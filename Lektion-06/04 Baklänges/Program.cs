Console.WriteLine("04 Baklänges");
Console.WriteLine("======================");
Console.WriteLine("\n\n");


for (int i = 10; i >= 1; i--)
{

    Console.Write($"{i} ", i);
    if (i == 1)
    {
        Console.Write("\t Gott nytt år!");
    }
}





Console.WriteLine("\n\n");
Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
