
using Lektion13.Uppgift08;
using Lektion13.Uppgift09;

namespace Lektion13.Uppgift10
{
    internal class Uppgift10Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 10: Flera abstrakta underklasser ===");
            Console.WriteLine();
            GeometriskForm Cirkel = new Cirkel();
            Cirkel.Rita();
            Console.WriteLine($"Objekttyp: {Cirkel.GetType().Name}");
            Console.WriteLine($"Basklass: {Cirkel.GetType().BaseType?.Name}");
            GeometriskForm Kvadrat = new Kvadrat();
            Kvadrat.Rita();
            Console.WriteLine($"Objekttyp: {Kvadrat.GetType().Name}");
            Console.WriteLine($"Basklass: {Kvadrat.GetType().BaseType?.Name}");
        }
    }
}
