
namespace Temperatur
{
    public class Termometer
    {
        private double _celsius;
        public double Celsius
        {
            get
            {
                return _celsius;
            }
            set
            {
                if (value < -273.15)
                {
                    
                    Console.WriteLine("Varning: Temperaturen är lägre än absolut nollpunkt (-273.15). Temperaturen har satts till -273.15.");
                    _celsius = -273.15;

                }
                else
                {
                    _celsius = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region header
            Console.WriteLine("09 Temperatur");
            Console.Title = "09 Temperatur";
            Console.WriteLine("==========================");
            Console.WriteLine();
            #endregion

            Termometer termometer = new Termometer
            {
                Celsius = -300
            };
            Console.WriteLine($"Celsius: {termometer.Celsius}");


            #region footer
            Console.WriteLine("\n\n==========================");
            Console.WriteLine("\nTryck på en tangent för att avsluta...");
            Console.ReadKey();
            #endregion
        }

    }
}