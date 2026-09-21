#region header
Console.WriteLine("04 Temperaturtips");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

void GeKlädråd(double temperatur)
{
    if(temperatur < 10.0)
    {
        Console.WriteLine();
        Console.WriteLine("Ta på dig en tjock jacka!");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("En tröja räcker gott!");
    }
}

Console.WriteLine("Hur många grader är det ute? ");
double temperatur = double.Parse(Console.ReadLine());
GeKlädråd(temperatur);



#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion