Console.WriteLine("05 Kvittoskrivaren");
Console.WriteLine("==============================");
Console.WriteLine("            KVITTO");
Console.WriteLine("==============================");

decimal pris = 18495.99m;

Console.WriteLine($"{"Produkt",-24}{"Pris",12}");
Console.WriteLine("------------------------------");
Console.WriteLine($"{"iPhone 18 Pro Max 256GB",-24}{pris,12:C}");
Console.WriteLine("------------------------------");
Console.WriteLine($"{"TOTALT",-24}{pris,12:C}");
Console.WriteLine("==============================");

Console.WriteLine("\nTack för ditt köp!");

Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();