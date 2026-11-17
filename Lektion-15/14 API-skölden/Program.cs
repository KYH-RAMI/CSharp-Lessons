
class InputSanitizer
{
    public string Sanitera(string råText)
    {
        if (råText == null)
        {
            throw new ArgumentNullException(
                nameof(råText),
                "Texten får inte vara null.");
        }

        return råText
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }
}
class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("14 Den säkra API-skölden");
        Console.Title = "14 Den säkra API-skölden";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion


        InputSanitizer inputSanitizer = new InputSanitizer();

        string[] texter =
        [
            "Hej <världen>!",
            "Hej >världen<!"
        ];

        foreach (string text in texter)
        {
            Console.WriteLine($"Original:  {text}");
            Console.WriteLine($"Saniterad: {inputSanitizer.Sanitera(text)}");
            Console.WriteLine();
        }


        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}