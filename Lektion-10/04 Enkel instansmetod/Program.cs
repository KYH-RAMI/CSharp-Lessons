
class Hund
{
    public string Namn { get; set; }
    public void Skall()
    {
        Console.WriteLine($"{Namn} skäller: Voff voff!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Enkel instansmetod");
        Console.Title = "04 Enkel instansmetod";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        //Hund 1 
        Hund hund1 = new Hund();
        hund1.Namn = "Hugo";
        hund1.Skall();

        Console.WriteLine();

        //Hund 2
        Hund hund2 = new Hund();
        hund2.Namn = "Sigge";
        hund2.Skall();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
