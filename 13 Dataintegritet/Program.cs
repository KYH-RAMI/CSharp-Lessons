
class SäkerLogger
{
    private string _text = string.Empty;
    private int _checksumma;

    private int BeräknaChecksumma(string text)
    {
        int antalA = text.Count(c => c == 'a' || c == 'A');

        return text.Length + antalA;
    }
    public void SkrivLogg(string text)
    {
        _text = text;
        _checksumma = BeräknaChecksumma(text);
    }
    public bool VerifieraIntegritet()
    {
        int aktuellChecksumma = BeräknaChecksumma(_text);

        return aktuellChecksumma == _checksumma;
    }

}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("13 Dataintegritet");
        Console.Title = "13 Dataintegritet";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        SäkerLogger logger = new SäkerLogger();

        logger.SkrivLogg("Motor startad.");

        bool ärIntakt = logger.VerifieraIntegritet();

        Console.WriteLine($"Loggens integritet är korrekt: {ärIntakt}");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}