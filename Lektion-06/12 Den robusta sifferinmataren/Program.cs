Console.WriteLine("12. Den robusta sifferinmataren");
Console.WriteLine("==========================");
Console.WriteLine();

do
{
    Console.Write("Ange ett heltal: ");
    string input = Console.ReadLine();
    int number = 0;

    if (int.TryParse(input, out number))
    {
        Console.WriteLine($"\n\nDu matade in: {number}\n");
        break;
    }
    else
    {
        Console.WriteLine("Försök igen! Det du matade in är inte ett heltal! ");
    }

} while (true);


Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();