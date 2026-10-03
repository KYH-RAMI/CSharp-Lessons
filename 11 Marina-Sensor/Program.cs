
interface ISensor
{
    string sensorNamn { get; }
    string LäsVärde();
}

class Vindsensor : ISensor
{
    public string sensorNamn => "Vindsensor";
    public string LäsVärde() => "12 knop";
}
class Djupsensor : ISensor
{
    public string sensorNamn => "Djupsensor";
    public string LäsVärde() => "4.2 meter";
}

class Batterimonitor : ISensor
{
    public string sensorNamn => "Batterimonitor";
    public string LäsVärde() => "13.4 V";
}
class SensorHanterare
{
    private readonly List<ISensor> _sensorer;

    public SensorHanterare(List<ISensor> sensorer)
    {
        _sensorer = sensorer;
    }

    public void VisaInstrumentpanel()
    {
        Console.WriteLine("=== SENSORPANEL ===");

        foreach (ISensor sensor in _sensorer)
        {
            Console.WriteLine($"{sensor.sensorNamn,-20} {sensor.LäsVärde()}");
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("11 Det marina sensor-nätverket");
        Console.Title = "11 Det marina sensor-nätverket";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        List<ISensor> sensorer =
        [
            new Vindsensor(),
            new Djupsensor(),
            new Batterimonitor()
        ];
        
        SensorHanterare hanterare = new SensorHanterare(sensorer);

        hanterare.VisaInstrumentpanel();

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}