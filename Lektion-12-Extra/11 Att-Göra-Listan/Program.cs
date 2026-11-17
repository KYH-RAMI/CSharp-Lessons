
class BåtUppgift
{
    public string Beskrivning { get; set; }
    public int Prioritet { get; set; }
    public BåtUppgift(string beskrivning, int prioritet)
    {
        Beskrivning = beskrivning;
        Prioritet = prioritet;
    }
    public static bool operator >(BåtUppgift uppgift1, BåtUppgift uppgift2)
    {
        return uppgift1.Prioritet > uppgift2.Prioritet;
    }
    public static bool operator <(BåtUppgift uppgift1, BåtUppgift uppgift2)
    {
        return uppgift1.Prioritet < uppgift2.Prioritet;
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 Att-Göra-Listan");
        Console.Title = "11 Att-Göra-Listan";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        BåtUppgift uppgift1 = new BåtUppgift("Laga läcka i kylvattenslang", 10);
        BåtUppgift uppgift2 = new BåtUppgift("Tvätta däcket", 2);

        if (uppgift1 > uppgift2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Måste göras först: {uppgift1.Beskrivning} (Prioritet {uppgift1.Prioritet})");
            Console.ResetColor();
        }
        else if (uppgift1 < uppgift2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Måste göras först: {uppgift2.Beskrivning} (Prioritet {uppgift2.Prioritet})");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Båda uppgifterna har samma prioritet.");
            Console.ResetColor();
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}