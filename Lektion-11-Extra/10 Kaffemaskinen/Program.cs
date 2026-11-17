
class CoffeeMachine
{
    public int WaterAmount;
    public int CoffeeBeans;
    public CoffeeMachine(int waterAmount, int coffeeBeans)
    {
        this.WaterAmount = waterAmount;
        this.CoffeeBeans = coffeeBeans;
    }
    public void BrewCoffee()
    {
        if (WaterAmount < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Varning: Ingen vatten kvar!");
            Console.ResetColor();
            return;
        }
        if (CoffeeBeans < 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Varning: Inga kaffebönor kvar!");
            Console.ResetColor();
            return;
        }
        WaterAmount--;
        CoffeeBeans--;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bryggde en kopp kaffe!");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("10 Kaffemaskinen");
        Console.Title = "10 Kaffemaskinen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        CoffeeMachine coffeeMachine = new CoffeeMachine(10, 3);
        for (int i = 0; i < 12; i++)
        {
            coffeeMachine.BrewCoffee();
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
