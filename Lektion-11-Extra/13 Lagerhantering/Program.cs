
class WarehouseItem
{
    private readonly string _itemNumber;
    private readonly string _name;
    private int _stock;
    public WarehouseItem(string itemNumber, string name, int initialStock)
    {
        this._itemNumber = itemNumber;
        this._name = name;
        this.Stock = initialStock; // Använd Stock-egenskapen för att sätta initialt saldo.
    }
    public string ItemNumber => _itemNumber;
    public string Name => _name;
    public int Stock
    {
        get => _stock;
        private set
        {
            if (value < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fel: Lagersaldo kan inte vara negativt. Försök att sätta saldo till {value} ignorerades. \n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Lagersaldo för {_name} ({_itemNumber}) uppdaterat till {value}. \n");
                Console.ResetColor();
                _stock = value;
            }
        }
    }
    public void AddStock(int amount)
    {
        if (amount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel: Kan endast lägga till ett positivt antal. \n");
            Console.ResetColor();
            return;
        }
        Stock += amount;
    }
    public void RemoveStock(int amount)
    {
        if (amount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel: Kan endast ta bort ett positivt antal. \n");
            Console.ResetColor();
            return;
        }

        if (amount > Stock)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: Kan inte ta bort {amount}. Endast {Stock} finns i lager. \n");
            Console.ResetColor();
            return;
        }

        Stock -= amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Lagerhantering");
        Console.Title = "13 Lagerhantering";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        WarehouseItem lampa = new WarehouseItem("12345", "Lampa", 10);

        lampa.AddStock(5);       // 10 → 15
        lampa.RemoveStock(3);    // 15 → 12
        lampa.RemoveStock(20);   // ska nekas
        lampa.AddStock(-5);      // ska nekas

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}