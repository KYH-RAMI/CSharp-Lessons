using Lektion13.Uppgift08;

namespace Lektion13.Uppgift09
{
    internal class Uppgift09Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 9: Abstraktion och override ===");
            Console.WriteLine();

            // Fungerar INTE – abstrakt klass.
            //  GeometriskForm form = new GeometriskForm(); Cannot create an instance of the abstract type or interface 'GeometriskForm'

            // Fungerar – konkret objekt av typen Cirkel.
            GeometriskForm form = new Cirkel();
            form.Rita();

            Console.WriteLine($"Objekttyp: {form.GetType().Name}");
            Console.WriteLine($"Basklass: {form.GetType().BaseType?.Name}");

        }
    }
}
