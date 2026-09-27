#region header
Console.WriteLine("15 Array-rotation utan extra minne");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

/*
 * 
 * 
 * Inte enkel uppgift. Behövde Assist med uppgiften... 
 * 
 *
 */


void RoteraHöger(int[] arr)
{
    if (arr.Length <= 1)
    {
        return;
    }

    int last = arr[arr.Length - 1]; // Spara sista elementet

    for (int i = arr.Length -1; i > 0; i--)
    {
        arr[i] = arr[i - 1];
    }

    arr[0] = last; // Lägg in sista elementet först.
}


int[] arr = { 1, 2, 3, 4, 5 };

Console.WriteLine("Före rotation: [" + string.Join(", ", arr) + "]");

RoteraHöger(arr);

Console.WriteLine("Efter rotation: [" + string.Join(", ", arr) + "]");


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion