
class NavigationsKärna
{
    private double _satellitData;
    private readonly double[] _koordinater;
    public NavigationsKärna()
    {
        _satellitData = 0.0;
        _koordinater = new double[3];
    }
    public double BeräknaKurs()
    {
        ValideraSatellitData();
        return UtförBeräkning();
    }
    private void ValideraSatellitData()
    {
        if (_satellitData < 0)
        {
            throw new InvalidOperationException("Satellitdata är ogiltig.");
        }
    }
    private double UtförBeräkning()
    {
        // Simulera en komplex beräkning baserad på satellitdata och koordinater
        return _satellitData * 1.5 + _koordinater[0] - _koordinater[1] + _koordinater[2];
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("12 SystemModulen");
        Console.Title = "12 SystemModulen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion
        NavigationsKärna navigation = new NavigationsKärna();

        double kurs = navigation.BeräknaKurs();

        Console.WriteLine($"Beräknad kurs: {kurs}");
        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}