using Lektion13.Uppgift11;

namespace Lektion13.Uppgift14
{
    internal class Uppgift14Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 14: Kombinera flera gränssnitt ===");
            Console.WriteLine();

            SmartKlocka klocka = new();
            ILaddbar laddbar = klocka;
            IGps gps = klocka;

            klocka.Ladda();
            klocka.HämtaPosition();

            Console.WriteLine($"Samma objekt: {ReferenceEquals(laddbar, gps)}");
            Console.WriteLine($"Samma typ: {laddbar.GetType() == gps.GetType()}");
            Console.WriteLine($"Implementerar även IGps: {laddbar is IGps}");


        }
    }
}
