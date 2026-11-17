
Console.WriteLine("11Skatteuträknaren med Overflow (checked/unchecked)");
Console.WriteLine("======================");

int tal1 = int.MaxValue;
int tal2 = 2;

// Checked
try
{
    int checkedResultat = checked(tal1 * tal2);
    Console.WriteLine($"Checked resultat: {checkedResultat}");
}
catch (OverflowException)
{
    Console.WriteLine("Checked: Overflow upptäcktes! Resultatet är för stort för en int.");
}

// Unchecked
int uncheckedResultat = unchecked(tal1 * tal2);

Console.WriteLine($"Tal 1: {tal1}");
Console.WriteLine($"Tal 2: {tal2}");
Console.WriteLine($"Unchecked resultat: {uncheckedResultat}");



Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey(); 