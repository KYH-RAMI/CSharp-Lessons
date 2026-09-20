Console.WriteLine("09 Menyvalet med nödutgång");
Console.WriteLine("==========================");
Console.WriteLine();

string[] menu =
{
    "1. Visa profil",
    "2. Ändra inställningar",
    "3. Avsluta"
};

while (true)
{
    Console.WriteLine("Alternativ:");
    Console.WriteLine(menu[0]);
    Console.WriteLine(menu[1]);
    Console.WriteLine(menu[2]);

    Console.Write("\nVälj ett alternativ: ");

    if (!int.TryParse(Console.ReadLine(), out int input))
    {
        Console.WriteLine("Felaktigt val.\n");
        continue;
    }

    switch (input)
    {
        case 1:
            Console.WriteLine("Visa profil\n");
            break;

        case 2:
            Console.WriteLine("Ändra inställningar\n");
            break;

        case 3:
            Console.WriteLine("Du valde: Avsluta");
            break;

        default:
            Console.WriteLine("Felaktigt val.\n");
            break;
    }

    if (input == 3)
    {
        break;
    }
}

Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
