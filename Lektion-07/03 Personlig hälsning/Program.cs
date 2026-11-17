#region header
Console.WriteLine("03 Personlig hälsning");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void HälsaAnvändare(string namn)
{
    Console.WriteLine($"Hej {namn}, hoppas du har en fantastisk dag på distansutbildningen!");
}

Console.WriteLine("Vad heter du? ");
string namn = Console.ReadLine();
HälsaAnvändare(namn);


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion