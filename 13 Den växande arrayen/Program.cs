#region header
Console.WriteLine("13 Den växande arrayen");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

int[] tal = new int[3];
int antal = 0;

while (true)
{
    if (antal == tal.Length)
    {
        int[] nyTalArray = new int[tal.Length * 2];

        for (int i = 0; i < tal.Length; i++)
        {
            nyTalArray[i] = tal[i];
        }

        tal = nyTalArray;

        Console.WriteLine($"Arrayen utökades till {tal.Length} platser.");
    }

    Console.Write("Mata in ett tal: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int nummer))
    {
        Console.WriteLine("Felaktig inmatning.");
        continue;
    }

    tal[antal] = nummer;
    antal++;
}
#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion