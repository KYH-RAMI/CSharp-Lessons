namespace Lektion13.Uppgift08
{
    internal class Uppgift08Demo
    {
        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 8: Abstrakta klasser ===");
            Console.WriteLine();

            Console.WriteLine($"Klass: {nameof(GeometriskForm)}");
            Console.WriteLine($"Är klassen abstrakt? {typeof(GeometriskForm).IsAbstract}");

            Console.WriteLine();
            Console.WriteLine("En abstrakt klass kan inte instansieras direkt.");
            Console.WriteLine("En konkret underklass måste implementera Rita().");

            // GeometriskForm form = new GeometriskForm();

            // Kompilatorfel CS0144:
            // Cannot create an instance of the abstract type or interface.
        }
    }
}