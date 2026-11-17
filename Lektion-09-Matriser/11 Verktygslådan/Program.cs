
static class  TextVerktyg
{
    public static int RaknaOrd(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }
        else
        {
            string[] ord = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return ord.Length;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 Verktygslådan");
        Console.Title = "11 Verktygslådan";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Console.WriteLine($"{TextVerktyg.RaknaOrd("Hej, hur mår du?")} ord");
        Console.WriteLine();
        Console.WriteLine($"{TextVerktyg.RaknaOrd("Jag heter Rami och håller på och försöker bemästra C#")} ord");
        Console.WriteLine();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
