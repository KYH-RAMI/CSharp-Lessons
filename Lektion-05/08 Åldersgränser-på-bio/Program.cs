Console.WriteLine("08 Åldersgränser på bio");
Console.WriteLine("======================");
Console.WriteLine("Ange din ålder: ");
int ålder = int.Parse(Console.ReadLine()!);
if(ålder >= 0 && ålder <= 6)
{
    Console.WriteLine("Du tillhör filmkategorin: Barntillåten");
}
else if (ålder >= 7 && ålder <= 10)
{
    Console.WriteLine("Du tillhör filmkategorin: Från 7 år");
}
else if (ålder >= 11 && ålder <= 14)
{
    Console.WriteLine("Du tillhör filmkategorin: Från 11 år");
}
else if (ålder >= 15)
{
    Console.WriteLine("Du tillhör filmkategorin: Från 15 år");
}
else
{
    Console.WriteLine("Felaktig inmatning. Ange en giltig ålder.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();