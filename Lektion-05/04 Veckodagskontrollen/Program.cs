Console.WriteLine("04 Veckodagskontrollen");
Console.WriteLine("======================");
Console.Write("Mata in ett heltal mellan 1 och 7: ");

string? msg = Console.ReadLine();

if (int.TryParse(msg, out int veckodag))
{
    switch (veckodag)
    {
        case 1:
            Console.WriteLine("Måndag");
            break;
        case 2:
            Console.WriteLine("Tisdag");
            break;
        case 3:
            Console.WriteLine("Onsdag");
            break;
        case 4:
            Console.WriteLine("Torsdag");
            break;
        case 5:
            Console.WriteLine("Fredag");
            break;
        case 6:
            Console.WriteLine("Lördag");
            break;
        case 7:
            Console.WriteLine("Söndag");
            break;
        default:
            Console.WriteLine("Felaktig inmatning.");
            break;
    }
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();