Console.WriteLine("11 Textanalysatorn");
Console.WriteLine("======================");
Console.WriteLine("Ange en text: ");
string text = Console.ReadLine()!;
Console.WriteLine("Du skrev: " + text);

if (text.Length == 0)
{
    Console.WriteLine("Texten är tom");
}
else if (text.StartsWith("Hejsan"))
{
    Console.WriteLine("Texten börjar på 'Hejsan'");
}
else if (text.EndsWith("!"))
{
    Console.WriteLine("Texten slutar med ett utropstecken");

}
Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();