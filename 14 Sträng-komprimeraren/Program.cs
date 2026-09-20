Console.WriteLine("14. Sträng-komprimeraren");
Console.WriteLine("==========================");
Console.WriteLine();

int antal = 1;
Console.Write("Ange en sträng: \n\n");
string input = Console.ReadLine().ToUpper();
Console.WriteLine();
Console.WriteLine("Komprimerad sträng: ");
for (int i = 1; i < input.Length; i++)
{
    if (input[i] == input[i - 1])
    {
        antal++;
    }
    else
    {
        Console.Write($"{input[i - 1]}{antal}");
        antal = 1;

    }
}

Console.Write($"{input[input.Length - 1]}{antal}");
Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();



