
class Produkt
{
    public string Produktnamn = "";

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("05 Produkt");
        Console.Title = "05 Produkt";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Produkt? produkt = null;

        if(produkt != null)
        {
            Console.WriteLine($"Produktnamn: {produkt.Produktnamn}");
        }
        else
        {
            Console.WriteLine("Produktnamn saknas");
        }



        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}