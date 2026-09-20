Console.WriteLine("05 Namnlistan");
Console.WriteLine("======================");
Console.WriteLine("\n\n");

Console.WriteLine("Array: \n");

string[] names = 
{ 
    "Rami", 
    "Gustav", 
    "Claes", 
    "Stig", 
    "Fredrik" 
};

foreach (string name in names)
{
    Console.WriteLine(name.ToUpper());
}

Console.WriteLine("\n\nLista: \n");
List<string> namesList = new List<string> 
{ 
    "Rami", 
    "Gustav", 
    "Claes", 
    "Stig", 
    "Fredrik" 
};

foreach (string name in namesList)
{
    Console.WriteLine(name.ToUpper());
}


Console.WriteLine("\n\n");
Console.WriteLine("============================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
