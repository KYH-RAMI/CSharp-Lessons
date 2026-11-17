
class BokningsReferens
{
    private string _referens;
    public string Referens
    {
        get => _referens;
        private set
        {
            if (!IsValidReferens(value))
            {
                throw new FormatException("Bokningsnumret måste ha formatet 'BÅT-XXXX' där XXXX är fyra siffror.");
            }
            _referens = value;
        }
    }
    public BokningsReferens(string referens)
    {
        Referens = referens;
    }
    private bool IsValidReferens(string referens)
    {
        if (string.IsNullOrWhiteSpace(referens)) return false;

        if (referens.Length != 8) return false;
        if (!referens.StartsWith("BÅT-", StringComparison.Ordinal)) return false;

        for (int i = 4; i < 8; i++)
        {
            if (!char.IsDigit(referens[i])) return false;
        }
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("06 Det robusta bokningsnumret");
        Console.Title = "06 Det robusta bokningsnumret";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        try
        {
            BokningsReferens bokning = new BokningsReferens("BÅT-1234");
            Console.WriteLine($"Giltig bokningsreferens: {bokning.Referens}");

            BokningsReferens felaktig = new BokningsReferens("BÅT-12A4");
        }
        catch (FormatException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fel: {ex.Message}");
            Console.ResetColor();
        }

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}