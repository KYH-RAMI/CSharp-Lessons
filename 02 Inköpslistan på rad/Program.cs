#region header
Console.WriteLine("02 Inköpslistan på rad");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

string[] KöpListan = new string[4]
{
    "Kebab",
    "Vitlökssås",
    "Tomatsås",
    "Bröd",
};

for (int i = 0; i < KöpListan.Length; i++)
{
    Console.WriteLine($"{KöpListan[i]}");
}
#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion