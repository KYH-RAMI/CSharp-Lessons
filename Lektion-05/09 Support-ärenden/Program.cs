Console.WriteLine("09 Support-ärenden");
Console.WriteLine("======================");
Console.WriteLine("Ange felkod: ");
int felkod = int.Parse(Console.ReadLine());
string felkodKategori = felkod switch
{
    >= 100 and <= 199 => "Hårdvarufel",
    >= 200 and <= 299 => "Mjukvarufel",
    _ => "Okänt fel"
};  
Console.WriteLine($"Felkod {felkod} kategoriseras som: {felkodKategori}");


Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();