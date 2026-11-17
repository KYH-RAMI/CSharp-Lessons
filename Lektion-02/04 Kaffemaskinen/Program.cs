
const int kaffepris = 15;

Console.Write("Hur koppar kaffe vill du ha? ");

int antalKoppar;

//int antalKoppar = int.Parse(Console.ReadLine() ?? "0");

//int antalKoppar = int.Parse(Console.ReadLine());

int.TryParse(Console.ReadLine(), out antalKoppar);


int totalPris = kaffepris * antalKoppar;

Console.WriteLine($"Totalpris: {totalPris}kr");



Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();