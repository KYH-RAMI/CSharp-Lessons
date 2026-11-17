
interface IVadersensor
{
    double HamtaTemperatur();
}

class VaderDisplay
{
    private readonly IVadersensor _sensor;
    public VaderDisplay(IVadersensor sensor) => _sensor = sensor;
    public void VisaTemperatur()
    {
        double temperatur = _sensor.HamtaTemperatur();
        Console.WriteLine($"Aktuell temperatur: {temperatur} °C");
    }
}
class Testsensor : IVadersensor
{
    private double _temperatur;

    public Testsensor(double temperatur)
        => _temperatur = temperatur;

    public double HamtaTemperatur()
        => _temperatur;

    public void SättTemperatur(double temperatur)
        => _temperatur = temperatur;
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("04 Väderstationen");
        Console.Title = "04 Väderstationen";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Testsensor sensor = new Testsensor(21.5);

        VaderDisplay display = new VaderDisplay(sensor);

        display.VisaTemperatur();

        sensor.SättTemperatur(18.7);
        display.VisaTemperatur();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}
