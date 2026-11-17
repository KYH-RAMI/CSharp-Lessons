
Console.WriteLine("12 Bitwise flaggor i praktiken (Skrivbordsrättigheter)");
Console.WriteLine("======================");

const int Read = 1;
const int Write = 2;
const int Execute = 4;


int rättigheter = Read | Write | Execute;

Console.WriteLine($"Startvärde: {rättigheter}");


Console.WriteLine($"Har Read: {(rättigheter & Read) != 0}");
Console.WriteLine($"Har Write: {(rättigheter & Write) != 0}");
Console.WriteLine($"Har Execute: {(rättigheter & Execute) != 0}");

rättigheter ^= Write;

Console.WriteLine("\nEfter XOR på Write:");
Console.WriteLine($"Har Write: {(rättigheter & Write) != 0}");

Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 