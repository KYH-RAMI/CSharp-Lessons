Console.WriteLine("06 Sökandet efter guld");
Console.WriteLine("======================");
Console.WriteLine("\n\n");

string[] items = 
{ 
    "Rep", 
    "Fackla", 
    "Guld", 
    "Karta", 
    "Kompass" 
};

foreach (string item in items)
{
    if (item == "Guld")
    {
        Console.WriteLine("Guld hittat!");
        break;
    }
    Console.WriteLine(item);
}

Console.WriteLine("\n\n");
Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
