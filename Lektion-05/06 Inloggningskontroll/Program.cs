Console.WriteLine("06 Inloggningskontroll");
Console.WriteLine("======================");
Console.Write("Användarnamn: ");

string? username = Console.ReadLine();

Console.Write("Lösenord: ");

string? password = Console.ReadLine();

if (username == "admin" && password == "hemligt123")
{
    Console.WriteLine("\nInloggning lyckades!");
}
else
{
    Console.WriteLine("\nFelaktiga uppgifter.");
}

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();  