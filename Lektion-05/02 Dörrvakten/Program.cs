Console.WriteLine("02 Dörrvakten");
Console.WriteLine("======================");
Console.Write("Vänligen mata in din ålder: ");

string? msg = Console.ReadLine();

if (int.TryParse(msg, out int age))
{
    if (age < 18)
    {
        Console.WriteLine("\nDu är minderårig.");
    }
    else
    {
        Console.WriteLine("\nVälkommen in!");
    }
}
else
{
    Console.WriteLine("\nFelaktig inmatning. Ange åldern med siffror.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();