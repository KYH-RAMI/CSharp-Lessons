
static double TolkaVindhastighet(string apiData)
{
    if (double.TryParse(apiData, out double vindhastighet))
    {
        return vindhastighet;
    }

    System.Diagnostics.Debug.WriteLine(
        $"Varning: Kunde inte tolka vindhastigheten '{apiData}'.");

    return 0.0;
}

#region header
Console.WriteLine("07 Säkrad API-parser");
Console.Title = "07 Säkrad API-parser";
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

double vind = TolkaVindhastighet("12,5");
Console.WriteLine($"Vindhastighet: {vind} m/s");

double felaktigVind = TolkaVindhastighet("storm");
Console.WriteLine($"Vindhastighet vid felaktig data: {felaktigVind} m/s");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion
