
class Order
{
    public string Ordernummer { get; }
    public string Kundnamn { get; }

    public List<string> Artiklar { get; } = [];

    public Order(string ordernummer, string kundnamn)
    {
        Ordernummer = ordernummer;
        Kundnamn = kundnamn;
    }

    public void LäggTillArtikel(string artikel)
        => Artiklar.Add(artikel);
}

class OrderPrinter
{
    public void SkrivUtOrder(Order order)
    {
        Console.WriteLine($"Ordernummer: {order.Ordernummer}");
        Console.WriteLine($"Kundnamn: {order.Kundnamn}");
        Console.WriteLine("Artiklar:");

        foreach (string artikel in order.Artiklar)
        {
            Console.WriteLine($"- {artikel}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("08 Orderhantering");
        Console.Title = "08 Orderhantering";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Order order = new Order("12345", "Rami Issa");
        order.LäggTillArtikel("Båt");
        order.LäggTillArtikel("Motor");
        order.LäggTillArtikel("Sjöfart");

        OrderPrinter printer = new OrderPrinter();
        printer.SkrivUtOrder(order);

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}