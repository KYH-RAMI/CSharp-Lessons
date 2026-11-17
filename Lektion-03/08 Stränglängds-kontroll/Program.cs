
Console.WriteLine("08Stränglängdskontroll (Null-conditional ?");
Console.WriteLine("======================");

//string? text = null;
string? text = "Hej!";

Console.WriteLine(text?.Length ?? 0);

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 