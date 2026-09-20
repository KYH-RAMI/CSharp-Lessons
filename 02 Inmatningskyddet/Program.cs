
Console.WriteLine("02 Inmatningskyddet");
Console.WriteLine("======================");

var lösenord = "hemligt";
bool korrektLösenord = false;

do
{
    Console.Write("Ange lösenord: ");
    var inmatning = Console.ReadLine();
    if(inmatning == lösenord)
    {
        Console.WriteLine("\n\nSystem: WOHOO!!! Rätt lösenord!\n\n");
        korrektLösenord = true;
    }
    else
    {
        Console.WriteLine("Fel lösenord, försök igen.");
        korrektLösenord = false;
    }
} while (korrektLösenord == false);


Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();