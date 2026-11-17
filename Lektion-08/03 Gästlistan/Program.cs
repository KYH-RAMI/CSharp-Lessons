#region header
Console.WriteLine("03 Gästlistan");
Console.WriteLine("==========================");
Console.WriteLine();
#endregion

List<string> GästListan = new List<string>();

GästListan.Add("RoRo");
GästListan.Add("Rami");
GästListan.Add("Bobo");

Console.WriteLine($"Totalt anmälda gäster: {GästListan.Count}");


#region footer
Console.WriteLine("\n\n==========================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();
#endregion