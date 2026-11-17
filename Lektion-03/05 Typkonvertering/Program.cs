
Console.WriteLine("05 Implicit VS Explicit Typkonvertering");
Console.WriteLine("======================");

int tal = 500;
double konverteratTal = tal;

double stortTal = 123.45;
int heltTal = (int)stortTal;


Console.WriteLine($"Implicit konvertering: {konverteratTal}");
Console.WriteLine($"Explicit konvertering: {heltTal}");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 