#region header
Console.WriteLine("06 Kvittobyggaren");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void SkrivUtKvittoLine(string produkt, decimal pris)
{

    Console.WriteLine("==============================");
    Console.WriteLine("            KVITTO");
    Console.WriteLine("==============================");

    Console.WriteLine($"{"Produkt",-15}{"Pris",12}");
    Console.WriteLine("------------------------------");
    Console.WriteLine($"{produkt,-15}{pris,15:C}");
    Console.WriteLine("------------------------------");
    Console.WriteLine($"{"TOTALT",-15}{pris,15:C}");
    Console.WriteLine("==============================");

    Console.WriteLine("\nTack för ditt köp!");
}


SkrivUtKvittoLine("Kaffe", 35m);

    #region footer
    Console.WriteLine("\n\n==========================");
    Console.WriteLine("\nTryck på en tangent för att avsluta...");
    Console.ReadKey();
#endregion