#region header
Console.WriteLine("05 Skriv ut baklänges");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

int[] heltal = new int[5]
{
    1,
    2,
    3,
    4,
    5

};

for (int i = heltal.Length - 1; i >= 0; i--)
{
    Console.WriteLine(heltal[i]);
    Thread.Sleep(200);
}
#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion