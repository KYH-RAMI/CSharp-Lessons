#region header
Console.WriteLine("13 Referensmodifiering");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void UppdateraStatus(
    ref string nuvarandeStatus, 
    bool operationLyckades)
{

    if (operationLyckades)
    {
        nuvarandeStatus = "Aktiv och verifierad";
    }
    else
    {
        nuvarandeStatus = "Systemfel: Åtgärd krävs";

    }
}

string status = "Väntar";
Console.WriteLine($"Före: {status}");
UppdateraStatus(ref status, false);
Console.WriteLine($"Efter: {status}");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion