object variabel = 42;

switch (variabel)
{
    case string text:
        Console.WriteLine($"Sträng med längd {text.Length}");
        break;

    case int heltal:
        Console.WriteLine($"Heltal med värdet {heltal}");
        break;

    default:
        Console.WriteLine("Okänd datatyp");
        break;
}

Console.WriteLine("\n\n\tTryck på en tangent för att stänga fönstret...");

Console.ReadKey();