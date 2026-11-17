Console.WriteLine("12 Trippelvalidering av användardata");
Console.WriteLine("======================");
Console.WriteLine("Ange ett heltal: ");
string? tal = Console.ReadLine();

if (int.TryParse(tal, out int heltal))
{
    if (heltal % 2 == 0)
    {
        Console.WriteLine("Jämnt tal");
    }
    else
    {
        Console.WriteLine("Udda tal");
    }
    if (heltal > 0)
    {
        Console.WriteLine("Positivt tal");
    }
    else
    {
        Console.WriteLine("Negativt tal");

    }
}
else
{
    Console.WriteLine("Felaktig inmatning.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
