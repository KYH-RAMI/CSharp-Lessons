#region header
Console.WriteLine("10 Standardmeddelande");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void LoggaMeddelande(string meddelande, string loggTyp = "INFO")
{
    Console.WriteLine($"[{loggTyp}] - {meddelande}");

}

LoggaMeddelande("Hej och Välkommen");
LoggaMeddelande("Windows 98 i blåsväder", "ERROR");

#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion