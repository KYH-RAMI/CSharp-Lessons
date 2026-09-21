#region header
Console.WriteLine("01 Hälsningsroboten");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void VisaHälsning()
{
    Console.Clear(); // Rensa konsolen
    
    Console.ForegroundColor = ConsoleColor.Green; // Formatera textfärgen till Grön
    Console.WriteLine(); // Skriv ut en tom rad.
    Console.WriteLine("Välkommen till systemet! Robotaktiverad."); // Välkomst meddelandet.

}


VisaHälsning(); //anropa funktionen/metoden




#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion