
class Thermostat
{
    private double _currentTemperature;
    public double CurrentTemperature
    {
        get { return _currentTemperature; }
        set
        {
            if (value > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Varning: Temperaturen är över 30 grader!");
                Console.ResetColor();
            }
            else if (value < 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Varning: Temperaturen är under 15 grader!");
                Console.ResetColor();
            }
            _currentTemperature = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region header
        Console.WriteLine("07 Temperaturregulatorn");
        Console.Title = "07 Temperaturregulatorn";
        Console.WriteLine("==========================");
        Console.WriteLine();
        #endregion

        Thermostat thermostat = new Thermostat();
        thermostat.CurrentTemperature = 25;
        Console.WriteLine($"Aktuell temperatur: {thermostat.CurrentTemperature}°C");
        thermostat.CurrentTemperature = 35;
        Console.WriteLine($"Aktuell temperatur: {thermostat.CurrentTemperature}°C");
        thermostat.CurrentTemperature = 10;
        Console.WriteLine($"Aktuell temperatur: {thermostat.CurrentTemperature}°C");

        #region footer
        Console.WriteLine("\n\n==========================");
        Console.WriteLine("\nTryck på en tangent för att avsluta...");
        Console.ReadKey();
        #endregion
    }

}