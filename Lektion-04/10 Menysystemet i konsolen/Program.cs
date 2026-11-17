Console.WriteLine("10 Menysystemet i konsolen");
Console.WriteLine("======================");
string[] Meny =
{
    "Startsidan",
    "Om mig",
    "Kontakt",
    "Avsluta"
};

int vald = 0;
bool kör = true;

while (kör)
{
    Console.Clear();

    for (int i = 0; i < Meny.Length; i++)
    {
        if (i == vald)
        {
            Console.WriteLine($"> {Meny[i]}");
        }
        else
        {
            Console.WriteLine($"  {Meny[i]}");
        }
    }

    ConsoleKeyInfo tangent = Console.ReadKey(true);

    if (tangent.Key == ConsoleKey.UpArrow)
    {
        if (vald > 0)
        {
            vald--;
        }
    }
    else if (tangent.Key == ConsoleKey.DownArrow)
    {
        if (vald < Meny.Length - 1)
        {
            vald++;
        }
    }
}

Console.WriteLine("======================");


Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();