Console.WriteLine("11 Temperaturloggen");
Console.WriteLine("==========================");
Console.WriteLine();

double[] temperaturer =
{
    23.3,
    22.1,
    21.7,
    20.4,
    18.3
};
double summa = 0;
double högstaTemperatur = temperaturer[0];
Console.WriteLine("Temperaturer: ");

for (int i = 0; i < temperaturer.Length; i++)
{
    Console.WriteLine($"{temperaturer[i]}");
    summa += temperaturer[i];
    if (temperaturer[i] > högstaTemperatur)
    {
        högstaTemperatur = temperaturer[i];
    }
}
double medeltemperaturen = summa / temperaturer.Length;

Console.WriteLine($"\n\nDet finns {temperaturer.Length} temperaturer \n");
Console.WriteLine($"Medeltemperaturen är: {medeltemperaturen} grader.\n");
Console.WriteLine($"Dagens högsta temperatur var {högstaTemperatur} grader.\n");


Console.WriteLine("==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();