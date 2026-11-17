/*
 * 14. Kommandotolk for ett RPG-Inventory (Avancerat extramaterial)
Skapa en klass 'Item` med `Namn' (string). Skapa en klass 'Inventory` som innehåller en
`List<Item>' och en maxkapacitet (t.ex. 3 saker). Lägg till metoder för `AddItem(Item i)` och
`ShowItems()`. Om listan ar full ska ett felmeddelande visas och foremålet nekas.

*/

class Item
{
    public string Namn { get; set; }
    public Item(string namn)
    {
        Namn = namn;
    }
}
class Inventory
{
    private List<Item> items = new List<Item>();
    private int _maxCapacity;
    public Inventory(int capacity)
    {
        _maxCapacity = capacity;
    }
    public void AddItem(Item i)
    {
        if (items.Count < _maxCapacity)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            items.Add(i);
            Console.WriteLine($"Lade till {i.Namn} i inventariet. \n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Inventariet är fullt! Kan inte lägga till fler saker. \n");
            Console.ResetColor();
        }
    }
    public void ShowItems()
    {
        if (items.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Inventariet är tomt. \n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Saker i inventariet: \n");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Namn}");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Kommandotolk för RPG-Inventory");
        Console.Title = "14 Kommandotolk för RPG-Inventory";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Inventory inventory = new Inventory(3);
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Kommandon:");
            Console.WriteLine("1. Lägg till sak");
            Console.WriteLine("2. Visa saker");
            Console.WriteLine("3. Avsluta");
            Console.WriteLine();

            if (!int.TryParse(Console.ReadLine(), out int val))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste ange ett nummer! \n");
                Console.ResetColor();
                continue;
            }
            switch (val)
            {
                case 1:
                    Console.Write("Ange namn på saken: \n");
                    string itemName = Console.ReadLine();
                    Item newItem = new Item(itemName);
                    inventory.AddItem(newItem);
                    break;
                case 2:
                    inventory.ShowItems();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt kommando.");
                    break;
            }
        }

            #region footer
            Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}