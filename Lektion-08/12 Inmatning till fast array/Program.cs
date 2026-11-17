#region header
Console.WriteLine("12 Inmatning till fast array");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

int[] tal = new int[5];

int i = 0;

while (i < tal.Length)
{
    Console.WriteLine($"Mata in ett tal för index {i}: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int nummer))
    {
        Console.WriteLine("Felaktig inmatning. Försök igen.");
        continue;
    }

    tal[i] = nummer;
    i++;
}

Console.WriteLine("\n\nDu matade in följande tal: ");
for (int n = 0; n < tal.Length; n++)
{
    Console.WriteLine(tal[n]);
    Thread.Sleep(200);
}


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion