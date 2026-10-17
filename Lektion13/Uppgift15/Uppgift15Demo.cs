
using Lektion13.Uppgift11;

namespace Lektion13.Uppgift15
{
    internal class Uppgift15Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 15: Kombinera abstrakt klass med interface ===");
            Console.WriteLine();

            Robot robot = new();

            Maskin maskin = robot;
            ILaddbar laddbar = robot;

            // GetType() – frågar ett objekt vilken typ det har:
            Console.WriteLine($"Robot är en {maskin.GetType().Name}"); // Robot
            Console.WriteLine($"Robot är en {laddbar.GetType().Name}"); // Robot
            Console.WriteLine($"Robot är en {robot.GetType().Name}"); //Robot
            Console.WriteLine($"Robot är en {robot.GetType().BaseType?.Name}"); //Maskin

            // Maskin deklarerar ingen metod som heter Ladda().
            // maskin.Ladda(); // Kompileringsfel CS1061

            Console.WriteLine();
            laddbar.Ladda();

            Console.WriteLine($"Robot är en Maskin: {robot is Maskin}");
            Console.WriteLine($"Robot implementerar ILaddbar: {robot is ILaddbar}");
            Console.WriteLine($"Samma objekt: {ReferenceEquals(maskin, laddbar)}");


            // typeof() – hämtar information om en typ direkt:
            Console.WriteLine(typeof(Robot).Name);     // Robot
            Console.WriteLine(typeof(Maskin).Name);    // Maskin
            Console.WriteLine(typeof(ILaddbar).Name);  // ILaddbar
        }
    }
}
