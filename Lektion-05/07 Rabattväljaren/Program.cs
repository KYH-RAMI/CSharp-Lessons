Console.WriteLine("07 Rabattväljaren");
Console.WriteLine("======================");
Console.Write("Är du student? (ja/nej): ");
string? studentSvar = Console.ReadLine()?.ToLower();
Console.WriteLine("Har ni ett Mecenatkort? (ja/nej): ");
string? mecenatSvar = Console.ReadLine()?.ToLower();
if (studentSvar == "ja")
{
    if (mecenatSvar == "ja")
    {
        Console.WriteLine("Du får 20% rabatt!");
    }
    else if (mecenatSvar == "nej")
    {
        Console.WriteLine("Du får 10% rabatt!");
    }
    else
    {
        Console.WriteLine("Felaktig inmatning för Mecenatkort.");
    }
} else if (studentSvar == "nej")
{
    Console.WriteLine("Standardpris gäller.");
}
else
{
    Console.WriteLine("Felaktig inmatning för studentstatus.");
}
Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();