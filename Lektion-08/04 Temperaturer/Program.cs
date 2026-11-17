#region header
Console.WriteLine("04 Temperaturer");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

double[] Temperaturer = new double[7]
{
    18.00,
    19.00,
    20.00,
    21.00,
    24.00,
    22.00,
    23.00
};

double HögstaTemperatur = Temperaturer[0];

for (int i = 0; i < Temperaturer.Length; i++)
{
    if (Temperaturer[i] > HögstaTemperatur)
    {
        HögstaTemperatur = Temperaturer[i];
    }
}

Console.WriteLine($"Veckans högsta temperatur var på {HögstaTemperatur} grader. ");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion