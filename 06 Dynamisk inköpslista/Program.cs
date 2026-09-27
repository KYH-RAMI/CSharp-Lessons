#region header
Console.WriteLine("06 Dynamisk inköpstlista");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

List<string> InköpsListan = new List<string>();

while(true)
{
    Console.WriteLine("Lägg till vara: ");
    string? vara = Console.ReadLine();

    if(vara == "klar" || vara == "KLAR" || vara == "Klar")
    {
        break;
    }

    InköpsListan.Add(vara);
   
}
Console.WriteLine("\n\n");
Console.WriteLine("Hela inköpslistan: \n");
foreach(string vara in InköpsListan)
{
    Console.WriteLine(vara);
}

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion