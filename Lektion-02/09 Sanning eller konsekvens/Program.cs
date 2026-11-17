bool harKörkort = true;
bool harBil = false;
bool ärNykter = true;
bool fårKöraBil = harKörkort && harBil && ärNykter;

if(fårKöraBil)
{
    Console.WriteLine("Du får köra bil.");
}
else
{
    Console.WriteLine("Du får inte köra bil.");
}
Console.WriteLine($"Får du köra bil?: {fårKöraBil}");

Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();