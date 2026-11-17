

namespace Lektion13.Uppgift11
{
    internal class Uppgift11Demo
    {

        public static void Kör()
        {
            Console.WriteLine("=== Uppgift 11: Skapa ett enkelt gränssnitt(ILaddbar) ===");
            Console.WriteLine();
            Console.WriteLine($"Gränssnitt: {typeof(ILaddbar).Name}");
            Console.WriteLine($"Metod: {nameof(ILaddbar.Ladda)}()");
        }
    }
}
