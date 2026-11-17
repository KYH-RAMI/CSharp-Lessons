Console.WriteLine("04 Åldersverifiering för krogen");
Console.WriteLine("======================");
Console.WriteLine("Vänlingen mata in din ålder: ");
string? msg = Console.ReadLine();
Console.WriteLine("\n");
try
{
    int age = int.Parse(msg!);

    if (age >= 18)
    {
        Console.WriteLine("Välkommen in till krogen!");
    }
    else
    {
        Console.WriteLine("Tyvärr, du är för ung!");
    }
}
catch
{
    Console.WriteLine("Ajjabajjaa!!");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();