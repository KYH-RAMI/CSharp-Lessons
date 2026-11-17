Console.WriteLine("10 Biluthyrning");
Console.WriteLine("======================");
Console.WriteLine("Ange din ålder: ");
int ålder = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ange antal år med körkort: ");
int körkortÅr = int.Parse(Console.ReadLine()!);

if (ålder >= 25 && körkortÅr >= 3)
{
    Console.WriteLine("Du får hyra en sportbil.");
}
else
{
    Console.WriteLine("Du får inte hyra en sportbil.");
}       

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();