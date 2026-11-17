Console.Write("Vad heter du? ");
var namn = Console.ReadLine();
Console.Write("Favorithobby? ");
var hobby = Console.ReadLine();

string stortNamn = namn?.ToUpper() ?? "Okänt namn";
Console.WriteLine($"\n[BOT]:\tHej {stortNamn}! Din favorithobby är {hobby}.");


Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();


