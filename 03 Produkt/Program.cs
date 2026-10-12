/*
Uppgift 3: Klassen Produkt med en Metod
Skapa en klass som heter Produkt med fälten string namn och double pris. Lägg till
en metod i klassen som heter SkrivUtPris(). Metoden ska skriva ut: "Produkten
[namn] kostar[pris] kr."
*/

public class Produkt
{
    public string namn;
    public decimal pris;

    public void SkrivUtPris()
    {
        Console.WriteLine($"Produkten {namn} kostar {pris:C} \n");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("03 Produkt");
        Console.Title = "03 Produkt";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Produkt produkt1 = new Produkt();
        produkt1.namn = "Kaffebryggaren";
        produkt1.pris = 299.50m;

        Produkt produkt2 = new Produkt();
        produkt2.namn = "Pizzaugn";
        produkt2.pris = 4999.99m;

        produkt1.SkrivUtPris();
        produkt2.SkrivUtPris();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}