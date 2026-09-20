Console.WriteLine("10 Textanalysatorn");
Console.WriteLine("==========================");
Console.WriteLine();

Console.WriteLine("Skriv in en text: ");
string input = Console.ReadLine() ?? "";

int antal = 0;
Console.WriteLine();

foreach (char c in input)
{
    if(c == ' ')
    {
        antal++;
    }
}
Console.WriteLine();
Console.WriteLine($"Du har {antal} mellanslag i din text");


Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();